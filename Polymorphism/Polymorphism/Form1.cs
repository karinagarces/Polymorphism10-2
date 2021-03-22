using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ShowAnimalInfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }


        private void CreateAnimalButton_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("Regular Animal");
            ShowAnimalInfo(myAnimal);
        }

        private void CreateDogButton_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Fido");
            MessageBox.Show("The dog's name is " + myDog.Name);
            ShowAnimalInfo(myDog);
        }

        private void CreateCatButton_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Kitty");
            MessageBox.Show("The cat's name is " + myCat.Name);
            ShowAnimalInfo(myCat);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
