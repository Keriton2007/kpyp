   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   	 Task2   Task2.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Task2��5   	   $	��450��6   $	��800��6$   .��5	      � -   5         �Name$ 
LayoutRoot��5	      
������� � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��200 �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ textBlockHello��5      $��1��5      $��1��5      $��2��5      $��48(�5       �� TextAlignment$ Center=�5      �� 5   
   -   5         ��Name$ textBoxEnterName��5      *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Введите имя��5      $��Stretch=�5         WatermarkAlignment$ Center=�5      $��2��5       $��1��5!      $��2��5"      $��30��5#      $	��350��5$      	 �� TextAlignment$	 Center=�5%      �� 5&   
   -   5        
 ��Name$
 buttonEnter��5&      $��Сказать имя��5'      $��3��5(      $��2��5)      $	��200��5*      $��60��5+      �� 5,   
   -   5        $
 buttonClose��5,      $��Закрыть��5-      $��3��5.      $��2��5/      $��2��50      $	��200��51      $��60��52      �� 53   
   -   5        $
 buttonAbout��53      $��О программе��54      $��0��55      $��3��56      $	��200��57      $��60��58      59      5:      