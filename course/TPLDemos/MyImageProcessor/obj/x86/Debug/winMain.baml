   M S B A M L   `   `   `  ����  MyImageProcessor    MyImageProcessor.winMain   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��
MainWindow��5   6     � Title$  并行计算应用示例��6	   $	��300��6   $	��400��6(   .��5      ]� $��2q�6   .+�5   
   �� $	��Top=�6    �� Orientation$ 
Horizontal=�6*   $	��350��6C   .+�5      �� -   5        $��btnLoadPicture��5   a   $��	10 5 10 5q�6   $	��100��6)   $��Center=�65   $��装入图像��6R   6�   �� 5	      -   5        $��btnProcessImage��5	   a   $��	10 5 10 5q�6   $	��100��6)   $��Center=�65   $��处理图像��6R   6�   �� 5
      -   5        $��btnRestoreImage��5
   b   $��	10 5 10 5q�6   $	��100��6)   $��Center=�65   $��恢复原图像��6R   6�   5      �� 5   
   $	��Top=�6   $ 
Horizontal=�6*   $	��250��6C   .+�5      	� -   5        $��chkSingleThread��5   �   $��	10 5 10 5q�6   $��Center=�6.   $��Center=�6K   $��	单线程��6f    d� 	IsChecked$
 TrueY�6t   6�   	� 5      -   5        $��chkMultiThread��5   t   $��	10 5 10 5q�6   $��Center=�6.   $��Center=�6K   $��	多线程��6f   6t   �� 5      $��	10 5 10 5q�6   $��Center=�6+   $��20(�6H   $
��Bold"�6W   �� 5      -   5         �Name$ lblTime��5   '   
���  ��.�66   069    �� 5      .�6   毫秒6   5      5      �� 5   
   
���   �$��1q�6%    �� CornerRadius$ 10��69   ._�5      �� -   5        $��image1��5   E   $	��Top=�6   $��10q�6)   $
��Fill=�66   6E   5      5      5      