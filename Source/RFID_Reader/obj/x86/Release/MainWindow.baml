   M S B A M L   `   `   `  ����   RFID_Reader    RFID_Reader.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  RFID Reader��$	��350��$	��525������  �� EndPoint$ 1,0.5&� �� 
StartPoint$ 0,0.5&�.���  � Color$ 	#FF2828E2�� � Offset$ 1Q�� $ 	#FF5454CE��$ 0.516Q�� $ 	#FF383879��$ 0.123Q�� $ 	#FF6E6EBA��$ 0.492Q�� $ 	#FF4662B0��$ 0.205Q�� $ 	#FF2A2ACE��$ 0.311Q�� $ 	#FF2E2E4E��$ 0.689Q�� $ 	#FF3436CE��$ 0.156Q�.��� $��5q�$
��Auto�� � ColumnDefinitions �� $��8* ��� $
��111* ��� $
��268* ��� $	��98* ��� $��8* � � RowDefinitions �� $
��Auto ��� $
��auto ��� $
��116* ��� $
��auto �.+�]� ��. $��5��$	��Top=�.+�o� .@�m� $��_File��$��15(�$��2q�.@�m� -   $��E_xit���� -   $��textBlockTitle��
���   �$��28(�$��UltraExpanded&�$��Italic$�$
��Bold"�
�������$��1��$
��Auto��$��Stretch=� �� Padding$ 0q�$��Parallax RFID Reader USB�� �� TextAlignment$ Center=�$��Center=�$��1��$��3���� -   $��TextBoxRFID��$��1��$��2��$
��Auto��$��Stretch=�$��Stretch=�$
��Auto��$	��Top=�$��5q�$��3��$��20(�"	 �� VerticalScrollBarVisibility$
	 Auto=�$
 �� HorizontalScrollBarVisibility$

 Auto=��� -   $��textBoxStatus��$��1��$��3��$
��Auto��$
��Left=�$��Center=�$
��Auto��
���  ��$��5,5,0,5q�
�������$��Not Connected��$��15(�$ 4q��� -   $��ClearButton��
���   �
���   � �� 	ClickMode$ Press=�$��Clear��|�.  
�������$��3��$
��Auto��$��Stretch=�$��Center=�$��Stretch=�$��Center=�$
��Auto��$��3��$��5q�$��15(��� -   $��checkBoxBeepEnabled��
�������$
��Beep��$��15(�
�������$��2��$��24��$��Right=�$��Bottom=�$��3��$��54��$��5q� d� 	IsChecked ��    Settings �� Source# [   �� Path$ Default.BeepEnabled�