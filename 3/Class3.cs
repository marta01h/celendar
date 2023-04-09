< Window x: Class = "NotesListBoxTest.Window1"
    xmlns = "http://schemas.microsoft.com/winfx/20


    06 / xaml / presentation"xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"xmlns:notes=" 



clr -namespace:NotesListBox;assembly=NotesListBox"xmlns:local="clr-namespace:NotesListBoxTest;assembly="Title="Window1"Height="450"Width="650"MinHeight="450"MinWidth="650"WindowState="Maximized" 
    WindowStartupLocation="CenterScreen">

        <Grid>
            <!-- Here is the actual content-->
            <DockPanel LastChildFill = "True 
                         

        
        "Background="#ff595959">
  ......
 ......
 ......
 </DockPanel><!-- Here is my custom AdornerDecorator--><notes:NotesAdornerDecoratorx:Name="notesAdornerDecorator" />
    </Grid>
</Window>