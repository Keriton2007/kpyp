   M S B A M L   `   `   `  ���� 	  Task1    Task1.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  
MainWindow��$	��450��$	��800��.���  � RowDefinitions �� $
��1.5* ��� $��5* ��� $��5* ��� $
��1.5* � � ColumnDefinitions �� $��5* ��� $��2* �.+��� -    ��Name$ textBlockXMLPathFile��$��0��$��10q��� -    ��Name$ buttonOpenFile��$��Открыть��$��1��$��16(�$��10q�� $��1��$��1��$��10q� �� $
��0.5* ��� $��2* ��� $��2* �.+��� $��
Найти��$��0��$��14(��� -    ��Name$ textBoxFlowerType��$��1��$��10q� �� TextAlignment$ Center=��� -   $ buttonFindFlowerType��$��
Найти��$��2��$��16(�$��1��$��10q��� $��1��$��2��$��5q�$
��Auto=�$��Disabled=�.���� -   $ textBlockXMLFileContent��$
��Wrap=�� $��2��$��1��$��10q� �� $
��0.5* ��� $��2* ��� $��2* �.+��� $��Удаление��$��14(��� -   $ textBoxDeleteFlowerType��$��10q�$��1��$ Center=��� -   $ buttonDelete��$��Удалить��$��16(�$��10q�$��2���� -   $ 	buttonAdd��$��Добавить��$��3��$��16(�$��10q��� -	   $ 
buttonExit��$��
Выход��$��3��$��1��$��16(�$��10q�