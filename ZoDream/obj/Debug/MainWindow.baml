   M S B A M L   `   `   `  ����  ZoDream    ZoDream.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0ignorehttp://www.galasoft.ch/ignore     5   	   $	��300��5   	   $	��500��5	   	     � Title$  ZoDream��5
   	    � DataContext 5   	   �� *Main+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Skins/MainSkin.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   .+�5   
   �� ��6   �� *Moneys+ �� View 5      �� 5      .P�5      �� $��日期��6%    �� Width$	 100��61   	 �� DisplayMemberBinding	 6=   �� 
 �� Path$
 AddTime��� 5      $��类型��6%   	 61   �� $

 Kind��� 5      $��金额��6%   $	 100��61   	 6=   �� $
 Money��� 5       $��备注��6%   	 61   �� $
 Remark�5!      5#      �� 5$   
   $��添加��6   $��1��6   ��6+   �� *
AddCommand+5%      5&      