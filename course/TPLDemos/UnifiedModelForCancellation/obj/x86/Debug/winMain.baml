   M S B A M L   `   `   `  ����  UnifiedModelForCancellation)    #UnifiedModelForCancellation.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$$  统一线程取消模型示例��5   	    � SizeToContent$ WidthAndHeight=�6    � 
ResizeMode$ NoResize=�6;    � 	Resources 5         ThreadObjectTemplate � Value �� Path��%�   &	        �� 5   
   .R�5      �� .+�5      � $��20��6;   $	��220��6G   $��5q�6S   $��Center=�6^    6   �� $ Value�6^   5
      5      5      .��5      �� .+�5   
   ��  �� Padding$ 2q�6   
����  �$��1q�60   ._�5      �� -   5        $��
lstThreads��5   a   #��[  6   $��0q�6L   $��5q�6s   $	��200��6~   $	��250��6�   $��Center=�6�   5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� -   5        $��btnNewThread��5   $   $��新建线程��6   $��5q�6S   $��5q�6^   $��30��6j   �� 5      -   5        $��btnCancelThread��5   &   $��取消所有线程��6   $��5q�6[   $��5q�6f   $��30��6r   �� 5      -   5        $��
btnRestart��5   $   $��重新开始��6   $��5q�6O   $��5q�6Z   $��30��6f   5      5      5!      