   M S B A M L   `   `   `  ����A  =PlcApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PlcApp.ViewsPlcApp.Views  5   	       PlcApp.Views.LoginWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PlcApp.Views     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6    � ColumnDefinitions 5
   
   �� 5      $
��279* �6   �� 5      $
��121* �6   .+�5   
   �� -   5         ��Name$ loginButton��5      $��Log in��6&   $
��Left=�67   $��67��6R   $��195,304,0,0q�6^   $	��Top=�6s   $	��145��6�   6�   �� 5   
   -   5        $ cancelButton��5      $��Cancel��6'   $
��Left=�68   $��67��6S   $��412,304,0,0q�6_   $	��Top=�6t   $	��145��6�   6�   �� 5   
   -   5         ��Name$ usernameText��5      $
��Left=�6(   $��49��6C   $��268,102,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��216��6�   G� 5   
   -   5         G�Name$ passwordText��5      $
��Left=�6,   $��52��6G   $��	268,0,0,0q�6S   $��Center=�6f   $	��216��6�   �� 5   
   $
��Left=�6   $��59��6/   $��	97,26,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��585��6z   $��2��6�   �� 6�    � Language$ pl-pl�6�   $!�Type username and password.��6�   6�   �� 5   
   -   5         ��Name$ usernameLabel��5      $
��Left=�6+   $��49��6F   $��124,102,0,0q�6R   $
��Wrap=�6g   $	��Top=�6{   $	��109��6�   �� 6�   $ pl-pl�6�   $�Email/username��6�   6�   �� 5   
   -   5        $ passwordLabel��5      $
��Left=�6+   $��49��6F   $��	124,0,0,0q�6R   $
��Wrap=�6e   $��Center=�6y   $	��109��6�   �� 6�   $ pl-pl�6�   $�Password��6�   6�   5      5      