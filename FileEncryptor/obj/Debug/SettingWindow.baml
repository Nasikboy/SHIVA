   M S B A M L   `   `   `  ����	  SHIFA!    FileEncryptor.SettingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$#  Настройки ключа��5   	   $	��282��6!   $	��447��6.    � 
ResizeMode$ NoResize=�6:   .��5      � $��0,0,4,0q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5
   
   �� $
��Left=�6   $	��154��6-   $��	10,41,0,0q�6:    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��422��6y   ��6�   ��  �� Path$ 	PublicKey� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $"��Публичный ключ:��6   $
��Left=�6*   $��	10,15,0,0q�6E   $	��Top=�6X   $��26��6p   $	��207��6|   �� 5   
   -   5         ��Name$ bt_importPublicKey��5      $=��7Загрузить публичный ключ (ХМЛ)��6-   $
��Left=�6V   $��
10,209,0,0q�6q   $	��Top=�6�   $	��215��6�    J� RenderTransformOrigin$ 0.76,0&�6�   $��25��6�   6�   �� 5   
   -   5        $ bt_OK��5      $
��Ок��6    $
��Left=�6-   $��25��6H   $��267,209,0,0q�6T   $	��Top=�6i   $��70��6�   	 �� 	IsDefault	 . 6�   �� 5   
   -   5        $ 	bt_Cancel��5      $��Отмена��6$   $
��Left=�65   $��349,209,0,0q�6P   $	��Top=�6e   $��69��6}   $��25��6�   
 �� IsCancel
 . $ 
-1.827,0.4&�6�   5      5      