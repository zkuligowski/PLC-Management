   M S B A M L   `   `   `  ����A  =PlcApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PlcApp.ViewsPlcApp.Views  5   	   %    PlcApp.Views.RegistrationWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PlcApp.Views     5   	     � Title$  RegistrationWindow��5   	   $	��550��6$   $	��800��61   .��5	      � .+�5
   
   �� $
��Left=�6   $��56��6/   $��	22,10,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��285��6z   �� 6�   $�User Registration Form��6�   �� 6�   �� 6�   �� 6�   �� 6�   �� 6�   �� 6�   6�   �� 5   
   -   5         ��Name$ firstNameLabel��5      $
��Left=�6,   $��35��6G   $��	17,74,0,0q�6S   $
��Wrap=�6f   $	��Top=�6z   $	��178��6�   �� 6�   $�
First Name��6�   �� 6�    � Language$ pl-pl�6�   $�:��6�   �� 6�   �� 6�   6�   �� 5   
   -   5        $ surnameLabel��5      $
��Left=�6*   $��35��6E   $��
17,109,0,0q�6Q   $
��Wrap=�6e   $	��Top=�6y   $	��178��6�    J� RenderTransformOrigin$ 0.476,1.774&�6�   �� 6�   $�Surnam��6�   �� 6�   $ pl-pl�6�   $�e:��6�   6�   �� 5   
   -   5        $ 
emailLabel��5      $
��Left=�6(   $��35��6C   $��
17,149,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $	��178��6�   �� 6�   $�Email��6�   �� 6�   $ pl-pl�6�   $�:��6�   6�   �� 5   
   -   5        $ birthDateLabel��5      $
��Left=�6,   $��35��6G   $��
17,189,0,0q�6S   $
��Wrap=�6g   $	��Top=�6{   $	��178��6�   �� 6�   $�
Birth Date��6�   �� 6�   $ pl-pl�6�   $�:��6�   6�   �� 5   
   -   5        $ mobileNumberLabel��5      $
��Left=�6/   $��35��6J   $��
17,224,0,0q�6V   $
��Wrap=�6j   $	��Top=�6~   $	��178��6�   �� 6�   $�Mobile Number��6�   �� 6�   $ pl-pl�6�   $�:��6�   6�   �� 5   
   -   5        $ usernameLabel��5      $
��Left=�6+   $��35��6F   $��
17,257,0,0q�6R   $
��Wrap=�6f   $	��Top=�6z   $	��178��6�   �� 6�   $�Username��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5        $ passwordLabel��5      $
��Left=�6+   $��35��6F   $��
17,292,0,0q�6R   $
��Wrap=�6f   $	��Top=�6z   $	��178��6�   �� 6�   $�Password��6�   �� 6�   $ pl-pl�6�   $�:��6�   6�   �� 5   
   -   5        $ rePasswordLabel��5      $
��Left=�6-   $��35��6H   $��
17,332,0,0q�6T   $
��Wrap=�6h   $	��Top=�6|   $	��178��6�   �� 6�   $ pl-pl�6�   $�Re-Password:��6�   6�   �� 5   
   -	   5        $ rightsLevelLabel��5      $
��Left=�6.   $��35��6I   $��
17,372,0,0q�6U   $
��Wrap=�6i   $	��Top=�6}   $	��178��6�   �� 6�   $ pl-pl�6�   $�Rights level:��6�   6�   �� 5   
   -
   5         ��Name$ firstNameText��5      $
��Left=�6)   $��35��6D   $��
267,74,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��318��6�   �� 5   
   -   5        $ surnameText��5      $
��Left=�6'   $��35��6B   $��267,109,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��318��6�   �� 5   
   -   5        $ 	emailText��5      $
��Left=�6%   $��35��6@   $��267,149,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��318��6�   �� 5   
   -   5        $ mobileNumberText��5      $
��Left=�6,   $��35��6G   $��267,224,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��318��6�   �� 5   
   -   5        $ usernameText��5      $
��Left=�6(   $��35��6C   $��267,264,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��318��6�   G� 5   
   -   5         G�Name$ passwordText��5      $
��Left=�6,   $��23��6G   $��267,304,0,0q�6S   $	��Top=�6h   $	��318��6�   G� 5   
   -   5        $ rePasswordText��5      $
��Left=�6.   $��23��6I   $��267,332,0,0q�6U   $	��Top=�6j   $	��318��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ birthDateDatePicker��5      $
��Left=�62   $��30��6M   $��267,189,0,0q�6Y   $	��Top=�6n   $	��318��6�   �� 5   
   -   5         ��Name$ rightsLevelComboBox��5      $
��Left=�60   $��23��6K   $��267,367,0,0q�6W   $	��Top=�6l   $	��318��6�   .@�5      �� $��Admin��6   6-   �� 5      $��	User-read��6   61   �� 5      $��User-read/write��6   67   5       �� 5!   
   -   5        	 ��Name$	 RegisterButton��5!      $��Register��6)   $
��Left=�6<   $��49��6W   $��267,427,0,0q�6c   $	��Top=�6x   $	��165��6�   6�   �� 5"   
   -   5        $	 CancelButton��5"      $��Cancel��6'   $
��Left=�68   $��49��6S   $��483,427,0,0q�6_   $	��Top=�6t   $	��165��6�   6�   5$      5%      