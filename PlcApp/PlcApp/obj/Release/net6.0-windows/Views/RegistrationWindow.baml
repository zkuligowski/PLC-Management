   M S B A M L   `   `   `  ���� A  =PlcApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PlcApp.ViewsPlcApp.Views  %    PlcApp.Views.RegistrationWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:PlcApp.Views       � Title$  RegistrationWindow��$	��550��$	��800��.��� .+��� $
��Left=�$��56��$��	22,10,0,0q�$
��Wrap=�$	��Top=�$	��285���� $�User Registration Form���� �� �� �� �� �� �� -    ��Name$ firstNameLabel��$
��Left=�$��35��$��	17,74,0,0q�$
��Wrap=�$	��Top=�$	��178���� $�
First Name����  � Language$ pl-pl�$�:���� �� �� -   $ surnameLabel��$
��Left=�$��35��$��
17,109,0,0q�$
��Wrap=�$	��Top=�$	��178�� J� RenderTransformOrigin$ 0.476,1.774&��� $�Surnam���� $ pl-pl�$�e:���� -   $ 
emailLabel��$
��Left=�$��35��$��
17,149,0,0q�$
��Wrap=�$	��Top=�$	��178���� $�Email���� $ pl-pl�$�:���� -   $ birthDateLabel��$
��Left=�$��35��$��
17,189,0,0q�$
��Wrap=�$	��Top=�$	��178���� $�
Birth Date���� $ pl-pl�$�:���� -   $ mobileNumberLabel��$
��Left=�$��35��$��
17,224,0,0q�$
��Wrap=�$	��Top=�$	��178���� $�Mobile Number���� $ pl-pl�$�:���� -   $ usernameLabel��$
��Left=�$��35��$��
17,257,0,0q�$
��Wrap=�$	��Top=�$	��178���� $�Username���� $�:���� -   $ passwordLabel��$
��Left=�$��35��$��
17,292,0,0q�$
��Wrap=�$	��Top=�$	��178���� $�Password���� $ pl-pl�$�:���� -   $ rePasswordLabel��$
��Left=�$��35��$��
17,332,0,0q�$
��Wrap=�$	��Top=�$	��178���� $ pl-pl�$�Re-Password:���� -	   $ rightsLevelLabel��$
��Left=�$��35��$��
17,372,0,0q�$
��Wrap=�$	��Top=�$	��178���� $ pl-pl�$�Rights level:���� -
    ��Name$ firstNameText��$
��Left=�$��35��$��
267,74,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��318���� -   $ surnameText��$
��Left=�$��35��$��267,109,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��318���� -   $ 	emailText��$
��Left=�$��35��$��267,149,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��318���� -   $ mobileNumberText��$
��Left=�$��35��$��267,224,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��318���� -   $ usernameText��$
��Left=�$��35��$��267,264,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��318��G� -    G�Name$ passwordText��$
��Left=�$��23��$��267,304,0,0q�$	��Top=�$	��318��G� -   $ rePasswordText��$
��Left=�$��23��$��267,332,0,0q�$	��Top=�$	��318��(  "System.Windows.Controls.DatePicker  -     Name$ birthDateDatePicker��$
��Left=�$��30��$��267,189,0,0q�$	��Top=�$	��318���� -    ��Name$ rightsLevelComboBox��$
��Left=�$��23��$��267,367,0,0q�$	��Top=�$	��318��.@��� $��Admin���� $��	User-read���� $��User-read/write���� -   	 ��Name$	 RegisterButton��$��Register��$
��Left=�$��49��$��267,427,0,0q�$	��Top=�$	��165���� -   $	 CancelButton��$��Cancel��$
��Left=�$��49��$��483,427,0,0q�$	��Top=�$	��165��