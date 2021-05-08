using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Drinks_Program
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Object to hold all the drinks
        /// </summary>
        public List<Drinks> DrinksStorage;

        public Form1()
        {
            InitializeComponent();
            DrinksStorage = new List<Drinks>();

            var path = Application.StartupPath + "\\test.txt";
            if (File.Exists(path))
                DrinksStorage = JsonConvert.DeserializeObject<List<Drinks>>(File.ReadAllText(path));

            cmb_DrinkType.DataSource = Enum.GetNames(typeof(DrinkType));
        }

        /// <summary>
        /// Hide controls depending on type of drink selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_DrinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedValue)
            {
                case "Juice":
                    {
                        pnl_Fruit.Visible = true;
                        pnl_Alcohol.Visible = false;
                        break;
                    }
                case "Alcohol":
                    {
                        pnl_Fruit.Visible = false;
                        pnl_Alcohol.Visible = true;
                        break;
                    }
                case "Soda":
                    {
                        pnl_Fruit.Visible = false;
                        pnl_Alcohol.Visible = false;
                        cb_Carbonation.Checked = true;
                        break;
                    }
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// Save Object to local storage, could do anything db etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (cmb_DrinkType.SelectedValue)
            {
                case "Juice":
                    {
                        DrinksStorage.Add(new JuiceDrink(txt_Name.Text, txt_Fruit.Text));
                        break;
                    }
                case "Alcohol":
                    {
                        DrinksStorage.Add(new AlcoholDrink(txt_Name.Text, cb_Carbonation.Checked, nm_alcohol.Value));
                        break;
                    }
                case "Soda":
                    {
                        DrinksStorage.Add(new SodaDrink(txt_Name.Text, cb_Carbonation.Checked));
                        break;
                    }
            }

            var path = Application.StartupPath + "\\test.txt";

            //open file stream
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, DrinksStorage);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) => ClearForm();

        void ClearForm()
        {
            txt_Fruit.Text = "";
            txt_Name.Text = "";
            cb_Carbonation.Checked = false;
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(DrinksStorage);
            form2.ShowDialog();
        }
    }




    public enum DrinkType
    {
        Soda,
        Juice,
        Alcohol
    }

    /// <summary>
    /// base drink class
    /// </summary>
    public class Drinks
    {
        //All Drinks will have a type, name, description, whether carbonated or alcoholic.  Could make alcoholic only be alcohol drinks but for now it'll be all  
        public DrinkType DrinkType;
        //All Drinks will have a name
        string _name;
        bool _carbonated;
        string _description;
        bool _alcoholic;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public bool Carbonated
        {
            get => _carbonated;
            set => _carbonated = value;
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public bool Alcoholic
        {
            get => _alcoholic;
            set => _alcoholic = value;
        }

        public Drinks()
        {
            Name = "";
            Carbonated = false;
            Alcoholic = false;
        }

        public Drinks(string Name, bool Carbonation, bool Alcohol)
        {
            this.Name = Name;
            this.Carbonated = Carbonation;
            this.Alcoholic = Alcohol;
        }
    }
    /// <summary>
    /// alcohol defaulted to true and 1 percent alcohol
    /// </summary>
    public class AlcoholDrink : Drinks
    {
        decimal _percentage;
        public decimal AlcoholPercent
        {
            get => _percentage;
            set => _percentage = value;
        }

        public AlcoholDrink(string Name, bool Carbonation, decimal AlcoholicPercentage = 1, DrinkType drinkType = DrinkType.Alcohol, bool Alcohol = true)
        {
            this.Name = Name;
            this.Carbonated = Carbonation;
            this.DrinkType = drinkType;
            this.Alcoholic = Alcohol;
            this.AlcoholPercent = AlcoholicPercentage;
            this.Description = Name + "," + AlcoholPercent + "% Alcohol, " + (Carbonated ? " is Carbonated" : " is Non Carbonated");
        }
    }
    /// <summary>
    /// Juice is a drink with fruit.  You can override if carbonated and alcoholic though
    /// </summary>
    public class JuiceDrink : Drinks
    {
        string _fruit;
        public string Fruit
        {
            get => _fruit;
            set => _fruit = value;
        }
        public JuiceDrink(string Name, string FruitType, bool Carbonation = false, DrinkType drinkType = DrinkType.Juice, bool Alcohol = false)
        {
            this.Name = Name;
            this.Carbonated = Carbonation;
            this.DrinkType = drinkType;
            this.Alcoholic = Alcohol;
            this.Fruit = FruitType;
            this.Description = Name + ", made from " + Fruit + (Carbonated ? " is Carbonated" : " is Non Carbonated");
        }
    }

    public class SodaDrink : Drinks
    {
        public SodaDrink(string Name, bool Carbonation = true, DrinkType drinkType = DrinkType.Soda, bool Alcohol = false)
        {
            this.Name = Name;
            this.Carbonated = Carbonation;
            this.DrinkType = drinkType;
            this.Alcoholic = Alcohol;
            this.Description = Name + (Carbonated ? " is Carbonated" : " is Non Carbonated");
        }
    }



}
