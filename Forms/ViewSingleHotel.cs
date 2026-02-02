using cloudFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cloudFinal.Forms
{
    public partial class ViewSingleHotel : Form
    {
        private string dbName, containerName;
        private Hotel hotel;
        private Microsoft.Azure.Cosmos.Container container;
        public ViewSingleHotel()
        {
            InitializeComponent();
        }
        //הצגת פרטי המלון הנבחר
        private void ViewSingleHotel_Load(object sender, EventArgs e)
        {
            this.Text = $"DB:{dbName}, Container:{containerName}, Hotel ID:{hotel.id}, Hotel Name:{hotel.HotelName}";

            var option = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            richTextBox_ViewSingleHotal.Text = JsonSerializer.Serialize(hotel, option);
        }
        //בדיקת תקינות קובץ גייסון
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
        //כפתור שינוי פרטי המלון
        private async void btn_ReplaceHotel_Click(object sender, EventArgs e)
        {
            if (!checkJsonValidation(richTextBox_ViewSingleHotal.Text))
                return;

            Hotel updatedHotel = JsonSerializer.Deserialize<Hotel>(richTextBox_ViewSingleHotal.Text);

            try
            {
                await container.ReplaceItemAsync(updatedHotel, hotel.id, new Microsoft.Azure.Cosmos.PartitionKey(hotel.id));
                MessageBox.Show("Replace process of hotel id " + hotel.id + " succeeded", "replace succeeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Replace process of hotel id " + hotel.id + " failed we got the following exception\n" + ex.Message, "replace failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
        //כפתור מחיקת המלון
        private async void btn_DeleteHotel_Click(object sender, EventArgs e)
        {
            try
            {
                await container.DeleteItemAsync<Hotel>(hotel.id, new Microsoft.Azure.Cosmos.PartitionKey(hotel.id));

                MessageBox.Show("Delete process of hotel id " + hotel.id + " succeeded", "Delete succeeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete process of hotel id " + hotel.id + " failed we got the following exception\n" + ex.Message, "Delete failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
        
        //פעולה בונה המקבלת את הערכים בעת הלחיצה על בחירת מלון
        public ViewSingleHotel(string dbName, string containerName, Microsoft.Azure.Cosmos.Container container, Hotel hotel)
        {
            InitializeComponent();
            this.dbName = dbName;
            this.containerName = containerName;
            this.container = container;
            this.hotel = hotel;
        }
    }
}
