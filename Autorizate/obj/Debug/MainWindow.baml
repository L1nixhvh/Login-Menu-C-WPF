   M S B A M L   `   `   `  ����E  AAutorizate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Autorizate
Autorizate  5   	       Autorizate.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Autorizate     5   	     � Title$  
MainWindow��5   	   $	��420��6   $	��331��6)    � WindowStyle$
 None=�65    � WindowStartupLocation$ CenterScreen=�6H    � AllowsTransparency . ��6m   Z� ��6�   Z� .��5	      � -   5        .+�5
   
   �� -   5         ��Name$ bugs_fix��5
      $��-179,-52,498,466q�6�   ��6$   Z� ��6:   Z� ��6Q   Z�  �� SelectionBrush 6g   Z� 6�   �� 5   
   -   5         ��Name$ 
MainBorder��5      $��1q�6%    �� CornerRadius$ 10,10,10,10��69   ���	#FF121212._�5      � $��0,22,0,0q�6   .+�5      �� $��Hello��6   $��50(�6(   $��Center=�66   $	��Top=�6S   $��0,29,0,0q�6k   ���	#FF535353��6}   Z� 6�   �� 5      $��2q�6   $ 4,4,4,4��6-   $��66,161,65,198q�6D   ���	#FF535353._�5      �� -   5        $ Login��5   J      CustomTextBoxStyle#��[  6   $��Login��6Y    �� 	MaxLength$ 16��6f   ���	#FF535353$��Center=�6�   $��6,0,6,0q�6�   $��15(�6�   	 �� 
CaretBrush	 �	#FF535353 �	#FF5353536  5      �� 5      $��2q�6   $ 4,4,4,4��6-   $��66,234,65,125q�6D   ���	#FF535353._�5      � .+�5      G� -   5        
 G�Name$
 Password��5   V     CustomPasswordBoxStyle#��[ 6&    G� PasswordChar$	 ●��6h    G� 
CaretBrush �	#FF535353���	#FF535353$��6,3,6,3q�6�    G� 	MaxLength$ 14��6�   $��15(�6�   $y�Hidden=�6�    G� SelectionBrush �	#FF5353536�   �� 5      -   5        $ Password_block��5   2   $��Password��6"   #��[  6J   $��15(�6v   $��Center=�6�   $��6,0,6,0q�6�   ���	#FF535353	 �	#FF535353$ 14��6�    �	#FF53535365  5      5      �� 5      $��/Icons/icons8-user-48.png��6   $��-6,158,259,194q�6;   �� 5      $#��/Icons/icons8-password-64.png��6   $��-6,226,259,116q�6?   �� 5      -   5         ��Name$ Show_password��5   :   $��/Icons/icons8-eye-30.png��6   $��228,242,67,132q�6Q    � Cursor$
 Hand��6�   $y�	Collapsed=�6�    J� Opacity$	 0.3Q�6�   6�   �� 5      -   5        $ Hide_password��5   D   $(��"/Icons/icons8-hide-password-30.png��6   $
 Hand��6�   $��228,242,67,132q�6�   $	 0.3Q�6�   6�   �� 5      -	   5         ��Name$ Loading��5      $��
0,312,0,35q�6*   $
 Hand��6>   $��Center=�6L   $	��200��6i   ��6�   Z� ��6�   Z� ��6�   Z� ��5      �� 5       �� 
TargetType" ��6*   .R�5      �� $ Loading_Border��6%   $ 8��6=   $��2q�6N   
�������$	 0.2Q�6�   ��6b   Z� ._�5   "   �� $��Center=�63   $��Center=�6P   5       5!      .��5#      �� $��Log in��6    $��16(�6.   ���	#FF1212126<   5$      5%      5&      � 5'   
   $	��Top=�6   $��23��6'   .+�5(      �� -
   5        $ Resize��5(      $*��$/Icons/icons8-horizontal-line-26.png��6$   $
 Hand��6R   $��
265,4,46,1q�6`   $	 0.3Q�6t   6�   �� 5)      -   5        $ Closed��5)      $��
300,3,10,0q�6$   $
 Hand��68   $ ��/Icons/icons8-close-24.png��6F   $
��Fill=�6j   $	 0.3Q�6�   5*      5+      5-      