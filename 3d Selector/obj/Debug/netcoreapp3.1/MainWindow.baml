   M S B A M L   `   `   `  ����F  B3d Selector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:_3d_Selector_3d_Selector  5   	       _3d_Selector.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:_3d_Selector     5   	     � Title$  
MainWindow��5	   	   $	��800��6   $
��1500��6)   $��Center=�66   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��375* �6   �� 5      $
��125* �6   �� 5      $
��200* �6   .+�5   
   � $��0q�6   ���	#FF1A1A1A$��1��61    5      �� 5      $	��10* �6#   �� 5      $	��47* �6#   �� 5      $	��82* �6#   �� 5      $	��10* �6#    � RowDefinitions 5      �� 5      $	��10* �6    �� 5      $	��28* �6    �� 5      $	��28* �6    �� 5      $	��28* �6    �� 5      $
��180* �6    �� 5      $	��28* �6    �� 5       $	��10* �6    .+�5#      �� -   5        $��Select File��5#      $��Center=�6+   $��1��6H   $��1��6U   $��Center=�6e   $��71��6�   $��49��6�   ���	#FF616161
�������6�   �� 5$      -   5         ��Name$	 BTN��5$      $��Clear model��6"   $��Center=�68   $��1��6U   $��2��6b   $��Bottom=�6r   $	��124��6�   $��49��6�   ���	#FF616161
������� J� RenderTransformOrigin$ 0.303,2.303&�6�   $��0,0,0,10q�6
  �� 5%      -   5         ��Name$ 	textBox_1��5%      $��2��6)   $
��Left=�66   $��0,46,0,0q�6Q   $��TextBox��6c    �� TextWrapping$
 Wrap=�6r   $	��Top=�6�   $	��258��6�      	BrushTest#���   6�   $��4��6�   �� 5&      -   5        $��Exit Program��5&      $��Center=�6,   $��5��6I   $��2��6V   $��Center=�6f   $	��124��6�   $��49��6�   ���	#FF616161
�������$ 0.303,2.303&�6�   5'      � 5*   
   -   5         �Name$
 XAML��5*      $��0q�6   5,      � 5.   
   $��0q�6   $��2��6   ���	#FF1A1A1A.+�5/      &   System.Windows.Controls.DataGrid  -   5        $��Table��5/   .   ���	#FF1A1A1A   CanUserReorderColumns$ False��6;   	   CanUserResizeColumns$	 False��6Y   
   CanUserAddRows$
 False��6v      CanUserDeleteRows$ False��6�      CanUserResizeRows$ False��6�      
IsReadOnly$
 True��6�   6�   52      54      55      