   M S B A M L   `   `   `  ����E  AUchebPRAOA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:UchebPRAOA
UchebPRAOA  5   	       UchebPRAOA.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:UchebPRAOA     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   6*   �� 5      6   �� 5      $��50 �6   6*    � ColumnDefinitions 5   
   .+�5   
   � $��0��6   
����+��.+�5      �� $0��*Ремонт бытовой техники��6   $��Center=�65   $��Center=�6Q   $��50(�6n   5      �� 5   
   $��Center=�6   $��Center=�60    �� Orientation$ 
Horizontal=�6M   $��1��6f   .+�5      �� $��1��6   .+�5      �� $��Login��6   $��50(�6)   $	��250��67   $
��Left=�6C   $��20q�6^   6l   �� 5      $��Password��6   $��50(�6,   $	��250��6:   $
��Left=�6F   $��10q�6a   6o   5      �� 5      .+�5      �� -   5         ��Name$ LoginBox��5      $	��150��6,   $��60��68   $��30q�6D   $��Center=�6P   $��Center=�6k   6�   G� 5      -   5         G�Name$ PasswordBox��5      $	��150��63   $��60��6?   6M   5       5!      �� 5"   
   -   5        $��errMsg��5"   �   $y�Hidden=�6   
���  ��$��1��69   $��20��6F   $	��250��6R   $��Center=�6^   $��Bottom=�6{   $J��DНеверное имя пользователя или пароль��6�   6�   �� 5#   
   $��3��6   $ 
Horizontal=�6"   .+�5$      �� -   5         ��Name$
 Auth��5$      $��3��6#   $	��150��60   $��30��6<   $��
Войти��6H   $
��Left=�6X   $��Center=�6s   $��10q�6�   6�   �� 5%      -   5        $ Registration��5%      $��3��6+   $	��150��68   $��30��6D   $��Регистрация��6P   $
��Left=�6f   $��Center=�6�   $��10q�6�   6�   5&       � 5(   
   -   5          �Name$ 	MainFrame��5(      $��1��6#     � NavigationUIVisibility$ Hidden=�61   6S   5*      5+      