   M S B A M L   `   `   `  ����   MyImageProcessor    MyImageProcessor.winMain   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -   $��
MainWindow��  � Title$  并行计算应用示例��$	��300��$	��400��.��]� $��2q�.+��� $	��Top=� �� Orientation$ 
Horizontal=�$	��350��.+��� -   $��btnLoadPicture��$��	10 5 10 5q�$	��100��$��Center=�$��装入图像���� -   $��btnProcessImage��$��	10 5 10 5q�$	��100��$��Center=�$��处理图像���� -   $��btnRestoreImage��$��	10 5 10 5q�$	��100��$��Center=�$��恢复原图像���� $	��Top=�$ 
Horizontal=�$	��300��.+�	� -   $��chkSingleThread��$��	10 5 10 5q�$��Center=�$��Center=�$��	单线程�� d� 	IsChecked$
 TrueY�	� -   $��chkMultiThread��$��	10 5 10 5q�$��Center=�$��Center=�$��	多线程���� $��	10 5 10 5q�$��Center=�$��20(�$
��Bold"��� -    �Name$ lblTime��
���  ��.�0 �� .�毫秒�� 
���   �$��1q� �� CornerRadius$ 10��._��� -   $��image1��$	��Top=�$��10q�$
��Fill=�