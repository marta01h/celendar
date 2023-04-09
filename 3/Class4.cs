using System;
using System.Collections.Generic;
using System.Linq;
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
using NotesListBox;
using System.Collections.ObjectModel;

namespace NotesListBoxTest
{
    public partial class Window1 : Window
    {
        #region Ctor
        public Window1()
        {
            InitializeComponent();

            #region Wire up Routed Events
            //Wire up the Note Added Event, which will come from the 
            //NotesListBoxControl on the AdornerLayer
            EventManager.RegisterClassHandler(
            typeof(NotesListBoxControl),
            NotesListBoxControl.NoteAddedEvent,
            new NoteEventHandler(
            (s, ea) =>
            {
                Console.WriteLine(CreateNoteMessage(ea.Note));
            }));

            //Wire up the Note Removed Event, which will come from the 
            //NotesListBoxControl on the AdornerLayer
            EventManager.RegisterClassHandler(
            typeof(NotesListBoxControl),
            NotesListBoxControl.NoteRemovedEvent,
            new NoteEventHandler(
            (s, ea) =>
            {
                Console.WriteLine(CreateNoteMessage(ea.Note));
            }));

            //Wire up the Note Changed Event, which will come from the 
            //NotesListBoxControl on the AdornerLayer
            EventManager.RegisterClassHandler(
            typeof(NotesListBoxControl),
            NotesListBoxControl.NoteChangedEvent,
            new NoteEventHandler(
            (s, ea) =>
            {
                Console.WriteLine(CreateNoteMessage(ea.Note));
            }));
            #endregion

            this.Loaded += new RoutedEventHandler(Window1_Loaded);

        }
 #endregion

 .....
 .....
 .....

 private void lstPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            notesAdornerDecorator.DisplayNotes = (lstPeople.SelectedItem as Person).Notes;
        }
#endregion
    }
}