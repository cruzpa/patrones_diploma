using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace flyweight
{
    public partial class Form1 : Form
    {
        private FlyweightFactory factory;
        private PoliceDatabase policeDatabase;
        private BindingList<Car> cars;

        public Form1()
        {
            InitializeComponent();
            CreateFactory();
            cars = new BindingList<Car>();
            carsDataGridView.AutoGenerateColumns = true;
            carsDataGridView.DataSource = cars;
            ShowInitialFlyweights();
        }

        private void CreateFactory()
        {
            factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );

            policeDatabase = new PoliceDatabase(factory);
        }

        private void ShowInitialFlyweights()
        {
            outputTextBox.Text = string.Join(Environment.NewLine, factory.ListFlyweights());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Owner = ownerTextBox.Text.Trim(),
                Number = numberTextBox.Text.Trim(),
                Company = companyTextBox.Text.Trim(),
                Model = modelTextBox.Text.Trim(),
                Color = colorTextBox.Text.Trim()
            };

            cars.Add(car);

            List<string> output = policeDatabase.AddCar(car);
            output.AddRange(factory.ListFlyweights());

            outputTextBox.Text = string.Join(Environment.NewLine, output);
            ClearInputs();
        }

        private void ClearInputs()
        {
            ownerTextBox.Clear();
            numberTextBox.Clear();
            companyTextBox.Clear();
            modelTextBox.Clear();
            colorTextBox.Clear();
            ownerTextBox.Focus();
        }
    }
}
