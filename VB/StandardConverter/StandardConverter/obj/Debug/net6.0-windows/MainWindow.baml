   M S B A M L   `   `   `  ����L  HStandardConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StandardConverterStandardConverter  5   	   "    StandardConverter.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StandardConverter     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��587* �6   �� 5      $
��213* �6   .+�5   
   �� -   5         ��Name$ standardvolumeCombo��5      $
��Left=�60   $��
174,16,0,0q�6K   $	��Top=�6_   $	��120��6w   .@�5      �� $��
tablespoon��6   �� 5      $��fluid ounce��6   �� 5      $
��gill��6   �� 5      $	��cup��6   �� 5      $
��pint��6   �� 5      $��quart��6   �� 5      $��gallon��6   5      �� 5   
   -   5        $ metricvolumeCombo��5      $
��Left=�6.   $��
174,51,0,0q�6I   $	��Top=�6]   $	��120��6u   .@�5      �� $��
milliliter��6   �� 5      $��liter��6   �� 5      $��	kiloliter��6   5      �� 5   
   -   5        $ standardLengthCombo��5      $
��Left=�60   $��
174,90,0,0q�6K   $	��Top=�6_   $	��120��6w   .@�5      �� $
��inch��6   �� 5      $
��foot��6   �� 5      $
��yard��6   �� 5       $
��mile��6   5!      �� 5"   
   -   5        $ metricLengthCombo��5"      $
��Left=�6.   $��174,130,0,0q�6I   $	��Top=�6^   $	��120��6v   .@�5#      �� $��
millimeter��6   �� 5$      $��
centimeter��6   �� 5%      $��meter��6   �� 5&      $��	kilometer��6   5'      �� 5(   
   -   5         ��Name$ FromTextBox��5(      $
��Left=�6'   $��
375,28,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $��TextBox��6j   $	��Top=�6y   $	��120��6�   �� 5)   
   -   5        $ 	ToTextBox��5)      $
��Left=�6%   $��
375,63,0,0q�6@   $
 Wrap=�6T   $��TextBox��6h   $	��Top=�6w   $	��120��6�   �� 5*   
   -   5         ��Name$ ClearButton��5*      $��CLEAR��6&   $
��Left=�66   $��
35,142,0,0q�6Q   $	��Top=�6e   $��1��6}   �� 5+   
   -   5        $ volumeConvertButton_��5+      $��VOLUME CONVERT��6/   $
��Left=�6H   $��322,102,0,0q�6c   $	��Top=�6x   �� 5,   
   -	   5        $ lengthConvertButton��5,      $��LENGTH CONVERT��6.   $
��Left=�6G   $��467,102,0,0q�6b   $	��Top=�6w   �� 5-   
   -
   5         ��Name$ ___No_Name_��5-      $
��FROM��6%   $
��Left=�64   $��
322,24,0,0q�6O   $	��Top=�6c   �� 5.   
   -   5        $ ___No_Name__Copy��5.      $��TO��6*   $
��Left=�67   $��
331,57,0,0q�6R   $	��Top=�6f   �� 5/   
   $��STANDARD LENGTH��6   $
��Left=�6*   $��	34,88,0,0q�6E   $	��Top=�6X   �� 50   
   $��METRIC LENGTH��6   $
��Left=�6(   $��
34,128,0,0q�6C   $	��Top=�6W   �� 51   
   $��STANDARD VOLUME��6   $
��Left=�6*   $��	34,14,0,0q�6E   $	��Top=�6X   �� 52   
   $��METRIC VOLUME��6   $
��Left=�6(   $��	34,49,0,0q�6C   $	��Top=�6V   54      55      