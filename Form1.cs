using cloudFinal.DataStructures;
using cloudFinal.Forms;
using cloudFinal.Models;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cloudFinal
{
    public partial class Form1 : Form
    {//לקיחת השדות המתאימים מתוך הקובץ app.config
        private string developerId = ConfigurationManager.AppSettings["DeveloperId"];
        private string developerName = ConfigurationManager.AppSettings["DeveloperFullName"];
        private string developerMail = ConfigurationManager.AppSettings["DeveloperMail"];

        private string uri = ConfigurationManager.AppSettings["URI"];
        private string primaryKey = ConfigurationManager.AppSettings["PrimaryKey"];
        private string envType = ConfigurationManager.AppSettings["EnvType"];


        private string logFolderName = ConfigurationManager.AppSettings["Log Folder"];
        private string logFileName = ConfigurationManager.AppSettings["Log File Name"];
        private CosmosClient myCosmosClient;
        private bool dbSelected = false;
        //הפעלת האפליקציה
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {//יצירת cosmos client בתוך האמולטור
            try
            {
                myCosmosClient = new CosmosClient(uri, primaryKey);
                MessageBox.Show("cosmos client creation succeeded",
                    "cosmos client was created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("cosmos client creation failed",
                  "cosmos client was failed",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Stop);

            }
            textBoxId.Text = developerId;
            textBoxName.Text = developerName;
            textBox_mail.Text = developerMail;

            textBox_envType.Text = envType;
            textBox_Uri.Text = uri;
            textBox_primaryKey.Text = primaryKey;

            WriteToLog("starting my cloud app");//תיעוד ללוג


        }
        //קובץ הלוג לתוכו יוזנו המקרים הדרושים במטלה
        private void WriteToLog(string logMessage)
        {
            try
            {
                string logFullPath = Path.Combine(logFolderName, logFileName);
                string fullLogMessage = $"{DateTime.Now:dd-MM-yyyy HH:mm:ss}: {logMessage}\n";
                if (!File.Exists(logFullPath))
                {
                    if (!Directory.Exists(logFolderName))
                        Directory.CreateDirectory(logFolderName);
                    File.Create(logFullPath);
                }
                File.AppendAllText(logFullPath, fullLogMessage);

            }
            catch (Exception myException)
            {
                MessageBox.Show("The operation '" + logMessage + "'was not append to the log,we got:" + myException.Message);

            }
        }
        //בכניסה לטאב בו נמצא הלוגהתוכן יתעדכן אוטומטית מבלי צורך בלחיצה על הכפתור
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            getUpdatedLogData();
        }
        //כפתור רפרוש תוכן הלוג
        private void btn_refreshData_Click(object sender, EventArgs e)
        {
            getUpdatedLogData();
        }
        //פונקציה המעדכנת את תוכן הלוג 
        private void getUpdatedLogData()
        {
            try
            {
                string logFullPath = Path.Combine(logFolderName, logFileName);
                if (File.Exists(logFullPath))
                {
                    string logData = File.ReadAllText(logFullPath, Encoding.UTF8);
                    richTextBox_Logger.Text = logData;
                }
                else
                {
                    if (!Directory.Exists(logFolderName)) Directory.CreateDirectory(logFolderName);
                    File.Create(logFullPath);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading log File...\n" + ex.Message,
                                "Error loading Log file",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        //  כפתור מחיקת כל הנתונים בתוך לוג מבלי למחוק את הקובץ
        private void btn_resetData_Click(object sender, EventArgs e)
        {
            try
            {
                string logFullPath = Path.Combine(logFolderName, logFileName);


                File.WriteAllText(logFullPath, string.Empty, Encoding.UTF8);


                getUpdatedLogData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting log file...\n" + ex.Message,
                                "Error resetting log file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
            }
        }
        //כפתור ליצירת בסיס נתונים או טבלה בתוך client
        private async void button_CrateDataInCloud_Click(object sender, EventArgs e)
        {
            try
            {
                
                string dbNameToCreate = textBox_DatabaseNameToCreate.Text;
                string containerNameToCreate = textBox_containerNameToCreate.Text;
                if (String.IsNullOrEmpty(dbNameToCreate))
                {
                    MessageBox.Show("Please fill At least Db Name","Wait!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    await createDBandContainerInCloud(dbNameToCreate, containerNameToCreate);
                    await LoadDataAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Creating Data: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
        //הפונקציה ה"חכמה" שמפעיל הכפתור ליצירת טבלה או בסיס נתונים יוצר בסיס נתונים חדש רק במידה
        //והוא אינו קיים כבר
        private async Task createDBandContainerInCloud(string dbNameToCreate, string containerNameToCreate)
        {
            MessageBox.Show("DB:" + dbNameToCreate + "\nTable:" + containerNameToCreate);
            DatabaseResponse databaseResponse = await myCosmosClient.CreateDatabaseIfNotExistsAsync(dbNameToCreate);
            System.Net.HttpStatusCode dbCreationStatus = databaseResponse.StatusCode;
            if (dbCreationStatus == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("DB'" + dbNameToCreate + "'was created",
                                "ceation succeeded",
                                 MessageBoxButtons.OK);
                WriteToLog("DBName '" + dbNameToCreate + "' was created by me");
            }
            else if (dbCreationStatus == System.Net.HttpStatusCode.OK)
                MessageBox.Show("DB'" + dbNameToCreate + "'wasnt created",
                                "already exist",
                                 MessageBoxButtons.OK);
            else
            {
                MessageBox.Show("DB'" + dbNameToCreate + "'wasnt created",
                                "DB creation failed",
                                 MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(containerNameToCreate)) return;
            Database dbobj = databaseResponse.Database;
            ContainerResponse ContainerResponse = await dbobj.CreateContainerIfNotExistsAsync(containerNameToCreate, "/id");
            System.Net.HttpStatusCode tableCreationStatus = ContainerResponse.StatusCode;
            if (tableCreationStatus == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Table'" + containerNameToCreate + "'was created",
                                "ceation succeeded",
                                 MessageBoxButtons.OK);
                WriteToLog($"Container '{containerNameToCreate}' created successfully");
            }
            else if (tableCreationStatus == System.Net.HttpStatusCode.OK)
                MessageBox.Show("Table'" + containerNameToCreate + "'wasnt created",
                                "table already exist",
                                 MessageBoxButtons.OK);
            else
                MessageBox.Show("Table'" + containerNameToCreate + "'wasnt created",
                                "table creation failed",
                                 MessageBoxButtons.OK);


        }
        //הצגת הנתונים בdataGrid
        private async void btn_ShowAllObjects_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }
        //הצגת שמות מסדי הנתונים עם הטבלאות שבתוכם כולל סכימת כל האובייקטים
        private async Task LoadDataAsync()
        {
            List<string> results = await getTotalNumOfObjectsForEachTableAsync();


            List<SearchResultsDBAndContainers> resultsasListOfClasses = await getTotalNumOfObjectsForEachTableClassViewAsync();
            dataGridView_Ex38.DataSource = resultsasListOfClasses;
            dataGridView_Ex38.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn colum in dataGridView_Ex38.Columns)
            {
                colum.DefaultCellStyle.Font = new Font("Arial", 17);
                colum.DefaultCellStyle.ForeColor = Color.Cyan;
            }

        }

        //סכימת כל האובייקטים במסד נתונים מסוים
        private async Task<List<SearchResultsDBAndContainers>> getTotalNumOfObjectsForEachTableClassViewAsync()
        {
            List<SearchResultsDBAndContainers> result = new List<SearchResultsDBAndContainers>();
            FeedIterator<DatabaseProperties> dbIterator = myCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            {
                foreach (DatabaseProperties currentDBProp in await dbIterator.ReadNextAsync())
                {
                    Database databaseRefObj = myCosmosClient.GetDatabase(currentDBProp.Id);
                    FeedIterator<ContainerProperties> tableIterator =
                        databaseRefObj.GetContainerQueryIterator<ContainerProperties>();
                    while (tableIterator.HasMoreResults)
                    {
                        foreach (ContainerProperties currentTableProp in await tableIterator.ReadNextAsync())
                        {
                            int totalNumOfObjInCurrentTable = 0;
                            Microsoft.Azure.Cosmos.Container tableRefObj = myCosmosClient.GetContainer(currentDBProp.Id, currentTableProp.Id);
                            FeedIterator<object> objIterator = tableRefObj.GetItemQueryIterator<object>();
                            while (objIterator.HasMoreResults)
                            {
                                foreach (object currentobj in await objIterator.ReadNextAsync())
                                    totalNumOfObjInCurrentTable++;


                            }
                            result.Add(new SearchResultsDBAndContainers
                            {
                                DatabaseName = currentDBProp.Id,
                                ContainerName = currentTableProp.Id,
                                TotalNumOfObj = totalNumOfObjInCurrentTable
                            });
                        }
                    }
                }
            }
            return result;
        }

        private async Task<List<string>> getTotalNumOfObjectsForEachTableAsync()
        {
            List<string> result = new List<string>();
            FeedIterator<DatabaseProperties> dbIterator = myCosmosClient.GetDatabaseQueryIterator<DatabaseProperties>();
            while (dbIterator.HasMoreResults)
            {
                foreach (DatabaseProperties currentDBProp in await dbIterator.ReadNextAsync())
                {

                    Database databaseRefObj = myCosmosClient.GetDatabase(currentDBProp.Id);
                    FeedIterator<ContainerProperties> tableIterator =
                        databaseRefObj.GetContainerQueryIterator<ContainerProperties>();
                    while (tableIterator.HasMoreResults)
                    {
                        foreach (ContainerProperties currentTableProp in await tableIterator.ReadNextAsync())
                        {
                            int totalNumOfObjInCurrentTable = 0;
                            Microsoft.Azure.Cosmos.Container tableRefObj = myCosmosClient.GetContainer(currentDBProp.Id, currentTableProp.Id);
                            FeedIterator<object> objIterator = tableRefObj.GetItemQueryIterator<object>();
                            while (objIterator.HasMoreResults)
                            {
                                foreach (object currentobj in await objIterator.ReadNextAsync())
                                    totalNumOfObjInCurrentTable++;

                            }
                            result.Add($"DB '{currentDBProp.Id}' -Table '{currentTableProp.Id}' - '{totalNumOfObjInCurrentTable}' objects");
                        }
                    }
                }
            }
            return result;

        }

        private async void tabPage3_Enter(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }
        private string selectedDB;
        private string selectedTable;
        
        //ריפרוש הלוגר
        private void button_refreshLoggerData_Click(object sender, EventArgs e)
        {
            getUpdatedLogData();
        }
        //ניקוי הלוגר
        private void buttonResetLoggerData_Click(object sender, EventArgs e)
        {
            try
            {
                string logFullPath = Path.Combine(logFolderName, logFileName);


                File.WriteAllText(logFullPath, string.Empty, Encoding.UTF8);


                getUpdatedLogData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting log file...\n" + ex.Message,
                                "Error resetting log file",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
            }
        }
       
        //חסימת שני הטאבים האחרונים עד בחירת בסיס נתונים וטבלה
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage4 || e.TabPage == tabPage3)
            {
                if (selectedDB == null || selectedTable == null)
                {
                    MessageBox.Show("select DB and Table");
                    e.Cancel = true;
                }
            }
        }
        private async void btn_presentHotels_Click(object sender, EventArgs e)
        {
           await presentHotels();
        }
        //הצגת מלונות לפי קריטריונים שהמשתמש בחר להכניס
        private async Task presentHotels()
        {
            string db = selectedDB;
            string table = selectedTable;
            Hotel searchCreteria = new Hotel();
            searchCreteria.id = textBox_Id.Text;
            searchCreteria.HotelName = textBox_HotelName.Text;
            if (textBox_NumOfStars.Text != null && textBox_NumOfStars.Text != "")
                searchCreteria.Stars = Convert.ToDouble(textBox_NumOfStars.Text);
            Room roomToSearch = new Room();
            roomToSearch.RoomType = textBox_RoomType.Text;
            if (!string.IsNullOrEmpty(textBox_Price.Text))
                roomToSearch.PricePerNight = Convert.ToInt32(textBox_Price.Text);
            searchCreteria.Rooms = new Room[1];
            searchCreteria.Rooms[0] = roomToSearch;
            Employee empToSearch = new Employee();
            empToSearch.FirstName = textBox_EmployeeName.Text;
            searchCreteria.Employees = new Employee[1];
            searchCreteria.Employees[0] = empToSearch;
            List<AdvancedSearch> results = await searchByUserCriteria(db, table, searchCreteria);
            dataGridView_Search.DataSource = results;
            dataGridView_Search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in dataGridView_Search.Columns)
            {
                col.DefaultCellStyle.Font = new Font("Arial", 14);
                col.DefaultCellStyle.ForeColor = Color.Cyan;
            }
        }
        private async Task<List<AdvancedSearch>> searchByUserCriteria(string db, string table, Hotel searchCreteria)
        {
            List<AdvancedSearch> result = new List<AdvancedSearch>();
            bool found;
            try
            {
                //Database databaseRefObj = myCosmosClient.GetDatabase(db);
                Microsoft.Azure.Cosmos.Container tableRefObj = myCosmosClient.GetContainer(db, table);

                FeedIterator<Hotel> hotelIterator = tableRefObj.GetItemQueryIterator<Hotel>();

                while (hotelIterator.HasMoreResults)
                {
                    foreach (Hotel currentHotel in await hotelIterator.ReadNextAsync())
                    {
                        found = true;
                        if (!string.IsNullOrEmpty(searchCreteria.id))
                        {
                            if (!string.IsNullOrEmpty(currentHotel.id) &&
                                currentHotel.id.Equals(searchCreteria.id))
                                found = true;
                            else
                                continue;
                        }

                        if (!string.IsNullOrEmpty(searchCreteria.HotelName))
                        {
                            if (!string.IsNullOrEmpty(currentHotel.HotelName) &&
                                currentHotel.HotelName.Equals(searchCreteria.HotelName))
                                found = true;
                            else
                                continue;
                        }

                        if (searchCreteria.Stars != 0)
                        {
                            if (currentHotel.Stars == searchCreteria.Stars)
                                found = true;
                            else
                                continue;
                        }

                        if (searchCreteria.Rooms != null &&
                            searchCreteria.Rooms.Length > 0 &&
                            searchCreteria.Rooms[0] != null &&
                            (
                                !string.IsNullOrEmpty(searchCreteria.Rooms[0].RoomType) ||
                                searchCreteria.Rooms[0].PricePerNight != 0
                            ))
                        {
                            Room[] rooms = currentHotel.Rooms;
                            if (rooms == null || rooms.Length == 0) continue;

                            bool roomFound = false;

                            foreach (Room currentRoom in rooms)
                            {
                                if (currentRoom != null)
                                {
                                    bool ok = true;

                                    if (!string.IsNullOrEmpty(searchCreteria.Rooms[0].RoomType))
                                    {
                                        if (!string.IsNullOrEmpty(currentRoom.RoomType) &&
                                            currentRoom.RoomType.Equals(searchCreteria.Rooms[0].RoomType))
                                            ok = true;
                                        else
                                            ok = false;
                                    }

                                    if (searchCreteria.Rooms[0].PricePerNight != 0)
                                    {
                                        if (currentRoom.PricePerNight == searchCreteria.Rooms[0].PricePerNight)
                                            ok = ok && true;
                                        else
                                            ok = false;
                                    }

                                    if (ok)
                                    {
                                        roomFound = true;
                                        break;
                                    }
                                }
                            }

                            if (roomFound)
                                found = true;
                            else
                                found = false;
                        }

                        if (searchCreteria.Employees != null &&
                            searchCreteria.Employees.Length > 0 &&
                            searchCreteria.Employees[0] != null &&
                            !string.IsNullOrEmpty(searchCreteria.Employees[0].FirstName))
                        {
                            Employee[] employees = currentHotel.Employees;
                            if (employees == null || employees.Length == 0) continue;

                            bool empFound = false;

                            foreach (Employee currentEmp in employees)
                            {
                                if (currentEmp != null &&
                                    !string.IsNullOrEmpty(currentEmp.FirstName) &&
                                    currentEmp.FirstName.Equals(searchCreteria.Employees[0].FirstName))
                                {
                                    empFound = true;
                                    break;
                                }
                            }

                            if (empFound)
                                found = true;
                            else
                                found = false;
                        }

                        if (found)
                        {
                            result.Add(new AdvancedSearch
                            {
                                id = currentHotel.id,
                                description = currentHotel.ToString()
                            });
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("NotFound"))
                {
                    MessageBox.Show("Somthing went wrong Could not find DB or Container", "Error not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Text = $"not available";
                }
                else
                {
                    MessageBox.Show("Somthing went wrong: "+ex.Message, "Error not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            return result;
        }
        //בלחיצה כפולה על מסד נתונים וטבלה שמם יופיע בכותרת החלון והפרמטרים יועברו 
        //למשתנים שהגדרנו,וכן הבחירה תתעדכן לתוך הלוגר
        private void dataGridView_Ex38_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedDB =
                    dataGridView_Ex38.Rows[e.RowIndex]
                        .Cells["DatabaseName"].Value.ToString();

                selectedTable =
                    dataGridView_Ex38.Rows[e.RowIndex]
                        .Cells["ContainerName"].Value.ToString();

                WriteToLog($"User selected DB '{selectedDB}' and Table '{selectedTable}'");

                MessageBox.Show(
                    $"Selected DB: {selectedDB}\nSelected Table: {selectedTable}",
                    "Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Text = $"DB: {selectedDB}  Table: {selectedTable}";
            }
            catch (Exception ex)
            {
                WriteToLog("ERROR selecting DB/Table: " + ex.Message);

                MessageBox.Show(
                    "Failed to select database/table.\nCheck log file.",
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        //טעינת קובץ ג'ייסון
        private void loadJsonFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Compatible Json File";
            ofd.Filter = "JSON files (*.json)|*.json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String jsoncontentstring = File.ReadAllText(ofd.FileName);
                jsonRichTextBox.Text = jsoncontentstring;
            }
            else
            {
                MessageBox.Show("Cancel was pressed", "Cancelled", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //בהתאמה לרדיו שנבחר תתבצעהפעולה הנדרשת מחיקה עדכון או הוספה
        private async void buttonPerformActivityInCloud_Click(object sender, EventArgs e)
        {
            string selectedActivity = radioButton_insert.Checked ? "insert" : radioButton_delete.Checked ? "delete" : "replace";
            if (!radioButton_delete.Checked && !radioButton_insert.Checked && !radioButton_replace.Checked)
            {
                MessageBox.Show("no Action Selected", "Select action", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hotelAsStr = jsonRichTextBox.Text;
                bool validJson = checkJsonValidation(hotelAsStr);
                if (validJson)
                {
                    try
                    {
                        List<Hotel> hotels = Hotel.ConvertStringIntoList(hotelAsStr);

                        await performActivityInCloud(selectedActivity, selectedDB, selectedTable, hotels);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Somthing related to the json file went wrong: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        
                    }
                }
                else
                {
 
                    return;
                }
            }
        }
        //ביצוע הפעולה הנבחרת על מסד הנתונים בענן
        private async Task performActivityInCloud(string selectedActivity, string db, string tb, List<Hotel> hotels)
        {
            Microsoft.Azure.Cosmos.Container container = myCosmosClient.GetContainer(db, tb);
            try
            {
                foreach (Hotel hotel in hotels)
                {
                    if (selectedActivity == "insert")
                        await container.CreateItemAsync<Hotel>(hotel, new PartitionKey(hotel.id));
                    else if (selectedActivity == "delete")
                        await container.DeleteItemAsync<Hotel>(hotel.id, new PartitionKey(hotel.id));
                    else if (selectedActivity == "replace")
                        await container.ReplaceItemAsync<Hotel>(hotel, hotel.id, new PartitionKey(hotel.id));

                }
                MessageBox.Show("Success", "Successfully done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WriteToLog("hotels " + selectedActivity + " succesfully into " + db + " - " + tb);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //בדיקת תקינות קובץ הגייסון
        private bool checkJsonValidation(string hotelAsStr)
        {
            try
            {
                JsonDocument.Parse(hotelAsStr);
                return true;
            }
            catch
            {
                MessageBox.Show("json invalid,try again", "invalid json", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }
        }
        //ריפרוש אוטומטי של הלוגר בעת כניסה לטאב שלו
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            getUpdatedLogData();
        }

        private void groupBox13_Leave(object sender, EventArgs e)
        {
            string hotelAsStr = jsonRichTextBox.Text;
            bool validJson = checkJsonValidation(hotelAsStr);
            if (!validJson)
            {
                return;
            }
        }
        //בלחיצה כפולה מעבר אל חלון הצגת פרטי המלון
        private async void dataGridView_Search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return; 

                string hotelId =
                    dataGridView_Search.Rows[e.RowIndex]
                        .Cells["id"].Value.ToString();

                WriteToLog($"User double-clicked hotel id '{hotelId}' (DB '{selectedDB}', Table '{selectedTable}')");

                var container = myCosmosClient.GetContainer(selectedDB, selectedTable);

              
                ItemResponse<Hotel> response =
                    await container.ReadItemAsync<Hotel>(hotelId, new Microsoft.Azure.Cosmos.PartitionKey(hotelId));

                Hotel hotel = response.Resource;

                ViewSingleHotel frm = new ViewSingleHotel(selectedDB, selectedTable, container, hotel);
                frm.ShowDialog();

                MessageBox.Show(
                    $"Opened Hotel JSON window for id: {hotelId}",
                    "Open Hotel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                presentHotels();
            }
            catch (Exception ex)
            {
                WriteToLog("ERROR opening hotel window: " + ex.Message);

                MessageBox.Show(
                    "Failed to open hotel details window.\nCheck log file.",
                    "Open Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
    }
}
