   M S B A M L   `   `   `  ����O  KWPF-Personal-Finance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPF_Personal_Finance.ViewWPF_Personal_Finance.View  5   	   -    'WPF_Personal_Finance.View.AccountWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:WPF_Personal_Finance.View     5   	     � Title$  AccountWindow��5   	   $	��300��6   $	��300��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��	日期：��6   (  "System.Windows.Controls.DatePicker  5   
   $��1��66      SelectedDateFormat$
 Long=�6F      SelectedDate 6   �� *	AddTime+6F   �� 5   
   $��	余额：��6   $��1��6   �� 5   
   $��1��6)   $��1��66   ��6   �� *Money+66   �� 5   
   $��	备注：��6   $��2��6   �� 5   
    �� TextWrapping$
 Wrap=�6*   $��2��6>   $��1��6K    �� AcceptsReturn .  �� 
AcceptsTab . ��6   �� *Remark+6p   �� 5   
   $��保存��6   $��3��6>   $��2��6K   ��6   �� *SavaCommand+6K   5      5      