   M S B A M L   `   `   `  ����X  TAZUK.MainframeAutomationRobot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:AZUK.MainframeAutomationRobot.Controls&AZUK.MainframeAutomationRobot.Controls  5      ]3clr-namespace:AZUK.MainframeAutomationRobot.Helpers%AZUK.MainframeAutomationRobot.Helpers  5	      b ^Microsoft.Windows.Shell, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35bFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.ShellMicrosoft.Windows.Shell 5
      7    1AZUK.MainframeAutomationRobot.Views.ScreenControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Icontrols4clr-namespace:AZUK.MainframeAutomationRobot.Controls     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      Z VFirstFloor.ModernUI, Version=1.0.9.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  5      Ahelpers3clr-namespace:AZUK.MainframeAutomationRobot.Helpers  5	      SsyscmdFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.Shell  5
      -   5        >   8AZUK.MainframeAutomationRobot.Controls.ModernUserControl   Name$  Screen��5       � 	Resources 5      >   8AZUK.MainframeAutomationRobot.Helpers.StarWidthConverter   starWidthConverter  	BoolToVis��%:   &	        &	        5   
   6B   �� 5   
   6'   5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ NavigatedTo��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *NavigatedToCommand+5        5   
   $ NavigatedFrom��6   . 5         6$   �� *NavigatedFromCommand+5        5   
   $ NavigatingFrom��6   . 5         6$   �� *NavigatingFromCommand+5        5   
   $ FragmentNavigation��6   . 5         6$   �� *FragmentNavigationCommand+5        5    
   $ Loaded��6   . 5!         6$   �� *LoadedCommand+5"        5#   
   $ IsVisibleChanged��6   . 5$         6$   �� *IsVisibleChangedCommand+5%      .��5'      � $��0,0,0,0q�6    � RowDefinitions 5(   
   �� 5)      $��40 �6   �� 5*      $��40 �6   �� 5+      $��20 �6   �� 5,      $��* �6    � ColumnDefinitions 5/   
   �� 50      $��2* �6!   �� 51      $��1* �6!   �� 52      $��4* �6!   .+�54   
   �� $��Center=�6   $��Right=�6/   $
��Wrap=�6K   $��Screen Name:��6_   $��0��6s   $��0,0,5,0q�6�   �� 55   
   -   5         ��Name$ txtScreenName��55      	 �� TextWrapping$
	 Wrap=�6S   $��1��6g   $��2��6w   $��Center=�6�   $��	0,9,126,9q�6�   ��6)   �� *ScreenMapping.ScreenName+6�   �� 56   
   $��Center=�6   $��Right=�6/   $
��Wrap=�6�   $��Exit Command:��6�   $��0��6�   $��1��6�   $��0,0,5,0q�6�   y�6K   �� *ScreenMapping.IsRepeatable+
 �� 	Converter#
 [ 6�   �� 57   
   -   5        $ txtExitCommand��57      $
	 Wrap=�6�   $��1��6�   $��1��6�   $��2��6�   $��Center=�6�   $��	0,9,126,9q�6  y�6*   �� *ScreenMapping.IsRepeatable+#
 [ ��6�   �� *ScreenMapping.ExitCommand+6  �� 58   
   -   5         ��Name$ cbxRepeatable��58      $��2��6*   $��1��67   $��2��6G   $��Repeatable Screen��6�    d� 	IsChecked 6[   �� *ScreenMapping.IsRepeatable+6�   �� 59   
   -   5        $��ListCustomers��5:       �� SelectionMode$ Single=�5=      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5>      $��Stretch=�5?      $��Stretch=�5@      $	��100��5A      $��3��5B      $��0��5C      ��5;      ��  �� Path$ ColumnNames� �� SelectedItem 5<      �� $ SelectedColumnName�5D      7  1FirstFloor.ModernUI.Windows.Controls.ModernButton  5G   
   $��3��6   $��1��6(   $��0,60,0,0q�69   $��Center=�6K   $	��Top=�6h      EllipseDiameter$ 36Q�5H   @      	IconWidth$ 18Q�6U      
IconHeight$ 18Q�6d      IconData� ���X�P|O��:G�2рw#��C��:G�:�ќ�[mєl�p-�l����������g�C��\����\�Ѩ��X�X��p�q�����;���XyȢ$��L�'�X��p�q����P~��|�}PB��������(��Cф��P~��&}��_����@@L���@��T"��Lؿ`ќ&}��_ � ToolTip$ Add new Command��5K   @   *  $Microsoft.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome . ��5J   @   �� *
AddCommand+5L   @     5P   
   $��3��6   $��1��6(   $��	0,120,0,0q�68   $��Center=�6K   $	��Top=�6h   $ 36Q�5Q   @   $ 18Q�6U   $ 18Q�6d   F ��F���C�ଔTn5���7Tn5�Tn5��C���7�<R�ଔ�<R�F���C$ Add to the current screen��5T   @    . ��5S   @   �� *AddColumnCommand+5U   @     5X   
   $��3��6   $��1��6(   $��	0,180,0,0q�69   $��Center=�6L   $	��Top=�6i   $ 36Q�5Y   A   $ 18Q�6V   $ 18Q�6e   F ���d��C� ��Tn5��OTn5Ѭ<R��C��O�<R� ���<R��d��C$  Remove from current screen��5\   @    . ��5[   @   �� *RemoveCommand+5]   @   �� 5`   
   -   5        $��LVScreenMapping��5`      $
 TrueY�5d      $��3��5e      $��2��5f      ��5a      �� *ScreenMapping.Mappings+ �� NotifyOnTargetUpdated .  5b      �� $ SelectedMapping���5h      �� 5i       �� 
TargetType" ��6   .�5j      ��  �� Property � �� �� Value$ Stretch=�6C   5k       �� View 5o      �� 5p      .P�5q      �� ��5r      �� 5s      $��	Mandatory��6(   $
��Wrap=�69    �� CellTemplate 5u      �� 5v      .R�5w   "   �� $��Center=�6M    6+   �� *IsMandatory+6M   5x      5z      �� 5{      $
��Type��6%    5|      �� 5}      .R�5~   "   �� $��	10,0,-4,0q�6L    �� 
IsReadOnly . ��6*   �� $ 
Identifier�6_   5      5�      �� 5�      $��Command/ColumnName��6%    5�      �� 5�      .R�5�   "   �� $��	-4,0,-4,0q�6V   ��6*   �� $ CommandOrExcelColumn�6V   5�      5�      �� 5�      $��Screen Name/Field��6%    5�      �� 5�      .R�5�   "   �� $��	-4,0,-4,0q�6M   ��6*   �� $ ScreenField�6M   5�      5�      5�      5�      5�      5�      