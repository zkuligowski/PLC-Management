   M S B A M L   `   `   `  ���� A  =PlcApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PlcApp.ViewsPlcApp.Views      PlcApp.Views.LoginWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:PlcApp.Views       � Title$  Login��$	��450��$	��800��.���  J� RenderTransformOrigin$ 0.5,0.5&� � ColumnDefinitions �� $
��279* ��� $
��121* �.+��� -    ��Name$ loginButton��$��Log in��$
��Left=�$��67��$��195,304,0,0q�$	��Top=�$	��145���� -   $ cancelButton��$��Cancel��$
��Left=�$��67��$��412,304,0,0q�$	��Top=�$	��145���� -    ��Name$ usernameText��$
��Left=�$��49��$��268,102,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��216��G� -    G�Name$ passwordText��$
��Left=�$��52��$��	268,0,0,0q�$��Center=�$	��216���� $
��Left=�$��59��$��	97,26,0,0q�$
��Wrap=�$	��Top=�$	��585��$��2����  � Language$ pl-pl�$!�Type username and password.���� -    ��Name$ usernameLabel��$
��Left=�$��49��$��124,102,0,0q�$
��Wrap=�$	��Top=�$	��109���� $ pl-pl�$�Email/username���� -   $ passwordLabel��$
��Left=�$��49��$��	124,0,0,0q�$
��Wrap=�$��Center=�$	��109���� $ pl-pl�$�Password��