   M S B A M L   `   `   `  ����Z  VFirstFloor.ModernUI, Version=1.0.9.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a9V>clr-namespace:FirstFloor.ModernUI;assembly=FirstFloor.ModernUIFirstFloor.ModernUI  5      b ^Microsoft.Windows.Shell, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35bFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.ShellMicrosoft.Windows.Shell 5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source7    1FirstFloor.ModernUI.Windows.Controls.ModernWindow �� 
TargetType   MyModernWindow �� Property  WindowBackgroundContent �� Value  DefaultFontFamily  DefaultFontSize  
WindowText  WindowBorder&   System.Windows.Media.TextOptions �� 
TargetType ��Name/  )Microsoft.Windows.Shell.SystemParameters2   Current �� Source	 �� Path  WindowBackgroundColor
 �� Color � 	Resources  Key �� 
TargetName �� TargetProperty	 �� To g� Duration �Name � RowDefinitions    BackgroundContent � ColumnDefinitions � Title  ModernWindowTitle    IsTitleVisible � DataContext  	 BooleanToVisibilityConverter �� 	Converter    
TitleLinks*  $Microsoft.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome �� Orientation ��Name	 �� X1	 �� Y1	 �� X2	 �� Y2 
 SeparatorBackground  SystemButtonLink  �� ElementName! �� Triggers" �� Binding# �� RelativeSource$ �� Value% �� 
TargetName 
 Accent&    LogoData  NullToVisibilityConverter' �� ConverterParameter( �� Stretch#   FirstFloor.ModernUI.Resources)   Minimize* � ToolTip  SystemButton,  &Microsoft.Windows.Shell.SystemCommands+   MinimizeWindowCommand, �� Mode- �� AncestorType. ��Name/   Restore0   RestoreWindowCommand1 � UseLayoutRounding2   Maximize3   MaximizeWindowCommand4   Close  SystemCloseButton5   CloseWindowCommand5   /FirstFloor.ModernUI.Windows.Controls.ModernMenu6    MenuLinkGroups7   
LinkGroups8   SelectedSource9 �� Mode7   1FirstFloor.ModernUI.Windows.Controls.ModernButton:   EllipseDiameter;   	IconWidth<   
IconHeight=   IconData6   0FirstFloor.ModernUI.Windows.Controls.ModernFrame>  Name?    ContentLoader@   ContentLoaderA   SourceB   ResizeGripDirectionC �� TriggersD P� PropertyE P� Value  WindowBorderActiveF ]� 
ConditionsG �� PropertyH �� ValueI   CornerRadiusJ   GlassFrameThicknessK   UseAeroCaptionButtonsL   NonClientFrameEdges�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      0mui&http://firstfloorsoftware.com/ModernUI   5      KmodernUi>clr-namespace:FirstFloor.ModernUI;assembly=FirstFloor.ModernUI  5      QsyscmdFclr-namespace:Microsoft.Windows.Shell;assembly=Microsoft.Windows.Shell  5        5      �� 5   
   $7 1/FirstFloor.ModernUI;component/Assets/Button.xaml?�6   �� 5	   
   $; 5/FirstFloor.ModernUI;component/Assets/Converters.xaml?�6   �� 5
   
   $: 4/FirstFloor.ModernUI;component/Assets/TextBlock.xaml?�6   %^  &	        7  7 	 7  7  7  7  7  7  �� 5      "   6   .�5   
   ��  �@  BackgroundContent# �  6.   �� 5   
    � ��# �  6'   �� 5   
    � ��# �  6%   �� 5   
    � ��# �  6'   �� 5   
    � ��# �  6(   �� 5   
    � ��$	 800��6"   �� 5   
    � ��$	 640��6#   �� 5   
    � ��$	 320��6%   �� 5   
    � ��$	 320��6&   �� 5   
    �@�
ResizeMode$ CanResizeWithGrip=�6'   �� 5   
    �@�UseLayoutRounding . 6.   �� 5   
    �@ TextFormattingMode$ Display=�6;   �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� $ WindowBorder��6   ��63   �� # Z $#	 WindowNonClientFrameThickness���5      �� 5       WindowBorderBackground��#
 �  6N    5"      ���� 5#      BackgroundAnimation .��5$   "   �� $ WindowBorderBackground��61   $ Color�6`   # �  6�   $ 0:0:.6D�6�   5%      5&      ._�5(      �� #��z��6!   $��1q�6M   ._�5)      �� .u�5*   "   � $ 
LayoutRoot��6'    5+   &   �� 5,   *   $��36 �68   �� 5-   *   $
��Auto �68   �� 5.   *   $��* �68   .+�52   &   �� $��5��65   #��z 6F   � 55   &    56   *   �� 57   .   $��* �6?   �� 58   .   $
��Auto �6?   �� 59   .   $
��Auto �6?   �� 5:   .   $��96 �6?   .+�5>   *   �� #��z 64   $	��8,0q�6S   $��Center=�6`   8��  # z 5?   4   y�5@   4   �� 8  �� 5C   *   $��1��67   #��z 6G   $��0,0,24,0q�6r    . ��5D   .   �� 5E   2   .R�5F   6   �� $ 
Horizontal=�6A   5G   3   ��5I   .   �� 5J   2   .R�5K   6   �� $ 
Horizontal=�6A   .+�5L   :   �� $ 	Separator��6?   $ .5��6R   $ 3��6Z   $ .5��6a   $ 12��6i   $	��5,0q�6q   $��Center=�6~   #��� 
 6�   �� 5N   :   $#��mui:LinkCommands.NavigateLink��5O   A   8�� ��5N   A   �� *DisplayName+��5P   A   �� *Source+��5Q   A   �� $  ContentFrame��5R   A   5S   7   ! 5T   6   �� 5U   :   " 6F   �� # �� *PreviousData+$ 6�   Z� .a�5V   >   �� $% 	Separator��6[    � y�$ 	Collapsed=�6r   5W   ;   5Y   3   5[   +   �� 5^   *   $��2��61   #���  6A   $��36��6g   $��36��6r   $	��8,0q�6~   # z& 5_   1   y�5`   1   �� 8  $' inverse��._�5a   .   F� $
( Fill=�6D   
�������$��24��6`   $��24��6k   $��Center=�6w   $��Center=�6�   ��63   �� 6�   5b   +   �� 5e   *   $��3��65   $ 
Horizontal=�6E   $	��Top=�6^    . .+�5f   .   �� #* Z) 6�   8�� ��65   �� # Z+ ��5g   2   � 5h   6   $��13��6;   $��12��6F   $z�1,0,0,1,0,1W�6R   .+�5i   :   F� ����    ��[ � z ��[ 	$��8��6R   $��7��6\   $��Center=�6g   $��Center=�6�   $��2��5j   �   ��6?   �� *
Foreground+# �� $, FindAncestor=�$- ButtonL�6�   5k   7   5m   /   � 5n   .   $��1,0,1,0q�63   .+�5o   2   �� $. Restore��69   #* Z/ 6�   8�� $y�	Collapsed=�6�   ��6J   �� # Z0 ��5p   6   � 5q   :   $��13��6?   $��12��6J   1 . $z�1,0,0,1,.5,.5W�6o   .+�5r   >   F� X���Ѐ�     � z     � z ��[ �    ��- р�[ ��- �    �� р�[ �� р�[  z �     z 	$��8��6y   $��8��6�   $��Center=�6�   $��Center=�6�   $��1��5s   �   ��6C   �� *
Foreground+# �� $, FindAncestor=�$- ButtonL�6�   5t   ;   5v   3   �� 5w   2   $. Maximize��69   #* Z2 6�   8�� ��6K   �� # Z3 ��5x   6   � 5y   :   $��13��6?   $��12��6J   .+�5z   >   F� +����    @B �@T� @B �@T�  z �     z 	$��9��6`   $��8��6j   $��Center=�6u   $��Center=�6�   $��2��5{   �   ��6C   �� *
Foreground+# �� $, FindAncestor=�$- ButtonL�6�   5|   ;   5~   3   5   /   �� 5�   .   #* Z4 6�   8�� ��65   �� # Z5 ��5�   2   � 5�   6   $��13��6;   $��12��6F   $z�1,0,0,1,0,1W�6R   .+�5�   :   F� +����        � z ��j � z     �    ��j 	$��8��6\   $��7��6f   $��Center=�6q   $��Center=�6�   $	��1.5��5�   �   ��6?   �� *
Foreground+# �� $, FindAncestor=�$- ButtonL�6�   5�   7   5�   /   5�   +   5�   '   � 5�   &   $��1��6+    5�   *   �� 5�   .   $��42 �6?   �� 5�   .   $��* �6?   �� 5�   .   $��56 �6?   �� 5�   .   $��56 �6?   .+�5�   *     $��1��69   #7 z6 5�   >   8 5�   >   �� *Source+$  ContentFrame��$9 TwoWay=�5�   >     5�   *   $��2��6;   $��0,10,8,0q�6K   $��Right=�6]   $	��Top=�6y   $: 36Q�5�   @   $; 18Q�6U   $< 18Q�6d   a= ����!��ш�!�ހ�8���ހѸ� u�X4� u���x��C�X4� 6nѸ� 6n�8����ш�!��$��ApplicationCommands.New��5�   @   $* Create new screen��5�   @    . 5�   @     5�   *   $��3��6;   $��0,10,8,0q�6K   $��Right=�6]   $	��Top=�6y   $: 36Q�5�   @   $; 18Q�6U   $< 18Q�6d   �= ��< �K��H2(�T�)�:K)��;H2H2���;)�:K)(�T�2�K�< ����,@@�vW��K@�\�*����ф��@+��@�\��K�vW��,@@< �K�p��_)���@@���*̾;p40"�Ċ��_��T+U� 3���^p<��^�KT+U�+U��K��^p<��^� 3�+U��_�Ċ��"�p40h�;$�*��|����2,k��x
����l��쎂l����kx
�u]ӄ1�NO�#-�NO�J;�u]�` f@+���*�` fѨu]�J;ӜNO�#-�NO�1�u]�
S��k�ʡE��@@����ʡE��@@����
�,k��2Q��_)���@@$��ApplicationCommands.Save��5�   @   $* Finish Process��5�   @    . 5�   @   5�   '     5�   &   $> ContentFrame��66   $��3��6L   $��2��6Y   $��
42,8,16,16q�6j   #@ z? 6�   A 6~   �� *ContentSource+# �� *TemplatedParent+$9 TwoWay=�6�   � 5�   &   $ 
ResizeGrip��68   $��2��6+   
������ $y�	Collapsed=�6e   $��Right=�6|   $��Bottom=�6�   $B BottomRight=�6�   .+�5�   *   F� $��12��6/   $��12��6:   $��1q�6F   #���  5�   /   $��1��5�   /   $
( None=�5�   /   �����@B ��� ���- ��� �@KL ��� ���j ��� �@T� ��� ��ا ��� Ѐ� @T� р� �ا Ѐ�[ @T� р�[ �ا Ѐ�� @T� р�� �ا �@KL ��[ ���j ��[ �@T� ��[ ��ا ��[ Ѐ�[ @KL р�[ ��j Ѐ�� @KL р�� ��j �@T� �� ��ا �� Ѐ�� @B р�� ��- 5�   /   5�   '   5�   #   5�      5�      5�      C 5�      P� 5�      D �@�IsActiveE . . �5�      �� # �  6<    � ��5�      P� 5�      D �@�WindowState$E 	Maximized=�69   . �5�      �� $% Maximize��6%    � y�$ 	Collapsed=�6Q   �� 5�      $% Restore��6%    � y�$ Visible=�6P   �� 5�      $% 
LayoutRoot��6%    � ��$ 7q�6O   5�      P� 5�      D �@�WindowState$E Normal=�69   . �5�      �� $% Maximize��6%    � y�$ Visible=�6Q   �� 5�      $% Restore��6%    � y�$ 	Collapsed=�6P   5�      ]� 5�      F 5�      �� 5�   "   G �@�
ResizeMode$H CanResizeWithGrip=�6B   �� 5�   "   G �@�WindowState$H Normal=�6C   ./�5�      �� $% 
ResizeGrip��6%    � y�$ Visible=�6S   5�      5�      5�      �� 5�   
    �@ WindowChrome 5�        5�      $I 0��6&   $J 1q�67   K .  $
L None=�6m   5�      5�      5�      