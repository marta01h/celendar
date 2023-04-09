using System.Windows.Controls;
using System.Windows;
using System;

private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
{
    DateTime? selectedDate = calendar1.SelectedDate;

    MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
}