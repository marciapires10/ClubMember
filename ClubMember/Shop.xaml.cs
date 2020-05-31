﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClubMember
{
    /// <summary>
    /// Interaction logic for Shop.xaml
    /// </summary>
    public partial class Shop : Page
    {
        int count = 0;
        public Shop()
        {
            InitializeComponent();
            PageManager.pagemanager.setShoppingCart();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.GetShopOptions());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Beenie", 8);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Hoodie", 30);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Ball", 15);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Cap", 8);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Agenda", 5);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Pen", 4);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Jersey", 40);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Shorts", 20);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Scarf", 10);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            PageManager.pagemanager.GetShoppingCart().addToCart("MCFC Sticker", 2);
            count++;
            txtBlk.Text = count.ToString();
        }

        private void goToShoppingCart(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.GetShoppingCart());
            PageManager.pagemanager.GetShoppingCart().setMemberID(PageManager.pagemanager.getPerson().getID());
    }
    }
}
