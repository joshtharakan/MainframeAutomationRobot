   M S B A M L   `   `   `  ����X  TAZUK.MainframeAutomationRobot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:AZUK.MainframeAutomationRobot.Controls&AZUK.MainframeAutomationRobot.Controls  5      @    :AZUK.MainframeAutomationRobot.Views.ExcelFileUploadControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Icontrols4clr-namespace:AZUK.MainframeAutomationRobot.Controls     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      -   5        >   8AZUK.MainframeAutomationRobot.Controls.ModernUserControl   Name$  ExcelUpload��5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ NavigatedTo��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *NavigatedToCommand+5        5   
   $ NavigatedFrom��6   . 5         6$   �� *NavigatedFromCommand+5        5   
   $ NavigatingFrom��6   . 5         6$   �� *NavigatingFromCommand+5        5   
   $ FragmentNavigation��6   . 5         6$   �� *FragmentNavigationCommand+5        5   
   $ Loaded��6   . 5         6$   �� *LoadedCommand+5        5   
   $ IsVisibleChanged��6   . 5         6$   �� *IsVisibleChangedCommand+5      .��5       � $��0,0,0,0q�6    � RowDefinitions 5!   
   �� 5"      $��40 �6   �� 5#      $��40 �6   �� 5$      $��80 �6   �� 5%      $
��180* �6    � ColumnDefinitions 5'   
   �� 5(      $��0.352* �6!   �� 5)      $��0.648* �6!   .+�5+   
   �� $
��Left=�6   $��30��60   $��10,7,0,0q�6<   $	��Top=�6N   $��0��6f   $��2��6s   .+�5,      �� $
��Wrap=�6   $1��+Please start with uploading your Excel file��6,   $��18(�6_   5-      �� 5/   
   -   5         ��Name$ txtFilePath��5/      $��4,10.313,137,4.001q�6'    �� TextWrapping$
 Wrap=�6j   $��1��6~   $��2��6�   	 �� 
IsReadOnly	 . ��6C   �� *SelectedFile.FileName+6�   �� 50   
   -   5        
 ��Name$
 	btnBrowse��50      $��Right=�6$   $��0,8,13,4q�6@   $	��111��6R   $��Browse��6^   $��1��51      $��1��6   ��6-   �� *BrowseCommand+�� 53   
   $
��Wrap=�6   $��Sheet Name:��6(   $��2��6;   $��12,13,182,9q�6H   $��2��6]   �� 55   
   -   5         ��Name$ txtSheetName��55      $��4,10.313,137,4.001q�6(   $��2��6D   $��2��6Q   $��2��6b   ��6v   �� *SelectedFile.SheetNames+ �� SelectedItem 6�   �� *	SheetName+57      58      