   M S B A M L   `   `   `  ����O  KWPFDriversAndResults, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPFDriversAndResultsWPFDriversAndResults  5   	   Q-clr-namespace:WPFDriversAndResults.ConvertersWPFDriversAndResults.Converters  5   	   %    WPFDriversAndResults.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WPFDriversAndResults     5   	   D
converters-clr-namespace:WPFDriversAndResults.Converters     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1150��6)   
������� � 	Resources 5       �� Source�� 5   
   $( "Resources/MainWindowResources.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6      dgBorderStyle#��[  5      ._�5      &   System.Windows.Controls.DataGrid    dgStyle#��[ 6      
IsReadOnly . $ �� IsSynchronizedWithCurrentItem$
 TrueY�5   A     dgColumnHeaderStyle   ColumnHeaderStyle# [ 5        
dgRowStyle   RowStyle# [ 5        dgCellStyle   	CellStyle# [ 5       ��5      �� *DCResultList+	 �� SelectedItem	 5      �� *SelectedDCResult+
 �� 
GroupStyle
 5!      (  "System.Windows.Controls.GroupStyle  5"        
GroupStyle   ContainerStyle# [ 6!      Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%        dgFirstCellStyle,  &System.Windows.Controls.DataGridColumn   	CellStyle# [ 6)      Header$ 
Сезон��5'   )      CanUserResize .     CanUserReorder .    Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5)   )      
FontWeight$
 Bold"�5*   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5&   )   ��  �� Path$
 Year�5+        5,        dgTextCellStyle# [ 6)     dgColumnElementStyle   ElementStyle# [ 5-   )   $! Гоночная серия��5/   )    .   . $
 Auto 51   )    5.   )   �� $ RacingSeries� %	 !RacingSeriesEnumToStringConverter �� 	Converter# [	 52        53      # [ 6)   # [ 54   )   $ 
Пилот��56   )    .   . $
 Auto 58   )    55   )   �� $ DriverFullName�59        5:      # [ 6)   # [ 5;   )   $ Команда��5=   )    .   . $
 Auto 5?   )    5<   )   �� $
 Team� 
 TeamToStringConverter# [
 5@        5A      $ Победы��5B   )    .   . $
 Auto 5D   )    5A   )   �� $
 Wins�5E        5F      $ Очки��5G   )    .   . $
 Auto 5I   )    5F   )   �� $ Points�5J        5K        dgLastCellStyle# [ 6)   $ 
Место��5M   )    .   . $
 Auto 5O   )    5L   )   �� $ Place�5P      5R      5S      �� 5U   
   $��0��6   $��1��6     pnlBorderStyle#��[ 5V      ._�5W      ��   pnlStyle#��[ 6   .+�5X      �� $��Группировка��6     tblGroupingStyle#��[ 5Y      �� 5[        cbStyle#��[ 6    d� 	IsChecked 5\      �� *IsGroupedByDrivers+.��5]      ��   tblNextToCB#��[ 6    $��По пилотам��5^       5_      �� 5`      #��[ 6    5a      �� *IsGroupedByRacingSeries+.��5b      �� #��[ 6    $(��"По гоночным сериям��5c       5d      �� 5f        tblFirstHeader#��[ 6   $��
Пилот��5g      �� 5h        tbStyle#��[ 6   ��5i      �� *!SelectedDCResult.DriverFullName+�� 5j        	tblHeader#��[ 6   $��Чемпионат��5k      �� 5l      #��[ 6   ��5m      �� *SelectedDCResult.RacingSeries+�� 5n      #��[ 6   $��
Сезон��5o      �� 5p      #��[ 6   ��5q      �� *SelectedDCResult.Year+�� 5s        	btnDelete#��[ 6   $��Удалить��5t      ��5u      �� *DeleteCommand+��6;   �� *SelectedDCResult+5v      5w      5x      5y      