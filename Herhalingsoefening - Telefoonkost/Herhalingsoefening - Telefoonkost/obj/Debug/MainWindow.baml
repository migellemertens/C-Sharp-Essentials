   M S B A M L   `   `   `  ����\  XHerhalingsoefening - Telefoonkost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Herhalingsoefening___Telefoonkost!Herhalingsoefening___Telefoonkost  5   	   2    ,Herhalingsoefening___Telefoonkost.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Herhalingsoefening___Telefoonkost     5   	     � Title$  
MainWindow��5   	   $	��604��6   $	��964��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ label1��5
      $��	Beginuur:��6    $
��Left=�64   $��	75,89,0,0q�6O   $	��Top=�6b   $	��209��6z    J� RenderTransformOrigin$ 0.507,2.077&�6�   $��20(�6�   �� 5   
   -   5        $ label2��5      $��Beginminuut:��6    $
��Left=�67   $��
75,131,0,0q�6R   $	��Top=�6f   $	��209��6~   $��20(�6�   �� 5   
   -   5        $ label3��5      $��Einduur:��6    $
��Left=�63   $��
75,174,0,0q�6N   $	��Top=�6b   $	��209��6z   $��20(�6�   �� 5   
   -   5        $ label4��5      $��Eindminuut:��6    $
��Left=�66   $��
75,214,0,0q�6Q   $	��Top=�6e   $	��235��6}   $��20(�6�   �� 5   
   -   5        $ label5��5      $��Soort gesprek:��6    $
��Left=�69   $��
75,265,0,0q�6T   $	��Top=�6h   $	��235��6�   $��20(�6�   �� 5   
   -   5         ��Name$ txtBeginUur��5      $
��Left=�6'   $��30��6B   $��
332,93,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $��54��6�   $��20(�6�   �� 5   
   -   5        $ txtBeginMinuut��5      $
��Left=�6*   $��30��6E   $��332,134,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $��54��6�   $��20(�6�   �� 5   
   -   5        $ 
txtEindUur��5      $
��Left=�6&   $��30��6A   $��332,178,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $��54��6�   $��20(�6�   �� 5   
   -	   5        $ txtEindMinuut��5      $
��Left=�6)   $��30��6D   $��332,218,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $��54��6�   $��20(�6�   {�. 6�   �� 5   
   -
   5        $ txtSoortGesprek��5      $
��Left=�6+   $��30��6F   $��332,269,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $��54��6�   $��20(�6�   {�. 6�   �� 5   
   -   5        $ txtResultaat��5      $
��Left=�6(   $	��178��6C   $��
75,354,0,0q�6P   $
 Wrap=�6d   $��                  ��6x   $	��Top=�6�   $	��559��6�   $��20(�6�   �� 5   
   -   5         ��Name$ 
btnBereken��5      $��	Berekenen��6%   $��696,248,46,0q�69   $	��Top=�6O   $��24(�6g   6u   �� 5   
   -   5        $ 	btnWissen��5      $��Wissen��6$   $��696,310,46,0q�65   $	��Top=�6K   $��24(�6c   6q   �� 5   
   -   5        $ btnAfsluiten��5      $��	Afsluiten��6'   $��696,364,46,0q�6;   $	��Top=�6Q   $��24(�6i   6w   �� 5   
   -   5        $ label��5      $.��(Berekening kost van een telefoongesprek.��6   $��
240,26,0,0q�6R   $	��Top=�6f   ���	#FFDE2FBE$��44��6�   $	��465��6�   $��24(�6�   $
��Left=�6�   �� 5   
   -   5        $ label6��5      $4��.Z=zonaal, N=nationaal, I=internationaal, G=gsm��6    $
��Left=�6Y   $��332,310,0,0q�6t   $	��Top=�6�   $	��326��6�   $��30��6�   $��14(�6�   5      5      