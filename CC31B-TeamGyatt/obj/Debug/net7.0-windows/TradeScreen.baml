   M S B A M L   `   `   `  ����A  =Engine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE/clr-namespace:Engine.ViewModels;assembly=EngineEngine.ViewModels  5   	   J FCC31B-TeamGyatt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CC31B_TeamGyattCC31B_TeamGyatt 5   	   !   CC31B_TeamGyatt.TradeScreen   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   F
viewModels/clr-namespace:Engine.ViewModels;assembly=Engine     5   	   /localclr-namespace:CC31B_TeamGyatt     5   	     � WindowStartupLocation$  CenterOwner=�5
   	   $
��11pt(�5   	    � Title$ TradeScreen��5   	   $	��480��6   $	��640��6*   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��2��5      $��Center=�5      ��5      �� *CurrentTrader.Name+�� 5   
   $��1��6   $��0��6   $��Center=�5       $��Your Inventory��5!      �� 5"   
   $��1��6   $��1��6   $��Center=�5#      $��Trader's Inventory��5$      &   System.Windows.Controls.DataGrid  5&   
   $��2��6   $��0��6    $��10q�5'         AutoGenerateColumns$ False��5)         HeadersVisibility$ Column=�5*         CanUserAddRows$ False��5+         CanUserDeleteRows$ False��5,      "   VerticalScrollBarVisibility$
 Auto=�5-      ��5(      �� * CurrentPlayer.GroupedInventory+	   Columns	 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Description��6%      
IsReadOnly$
 True��50   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 51   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 52   %   ��  �� Path$ 	Item.Name�  53      $	
 Qty��6%   $
 True��54   %   $
 Auto 55   %    56   %   �� *
Quantity+  57      $
 Price��6%   $
 True��58   %   $
 Auto 59   %    5:   %   �� $ 
Item.Price�4  .System.Windows.Controls.DataGridTemplateColumn  5;         MinWidth$ 75Q�6)      CellTemplate 5<      �� 5=      .R�5>      �� -   5        $��55��5?   %   $��Sell 1��5@   %   5A      5C      5E        5F   
   $��2��6   $��1��6    $��10q�5G      $ False��5I      $ Column=�5J      $ False��5K      $ False��5L      $
 Auto=�5M      ��5H      �� * CurrentTrader.GroupedInventory+	 5N        5O      $
 Description��6%   $
 True��5P   %   $ * 5Q   %    5R   %   �� $ 	Item.Name�  5S      $	
 Qty��6%   $
 True��5T   %   $
 Auto 5U   %    5V   %   �� *
Quantity+  5W      $
 Price��6%   $
 True��5X   %   $
 Auto 5Y   %    5Z   %   �� $ 
Item.Price�  5[      $ 75Q�6)    5\      �� 5]      .R�5^      �� -   5        $��55��5_   %   $��Buy 1��5`   %   5a      5c      5e      �� 5f   
   -   5        $��3��5f      $��1��6   $��Right=�5g      $��75��5h      $��Close��5i      5j      5k      5l      