   M S B A M L   `   `   `  ����B  >Vraag 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Vraag_2Vraag_2  5   	       Vraag_2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Vraag_2     5   	     � Title$  Premie Ramen��5   	   $	��514��6   $	��916��6+   .��5	      ]� .+�5
   
   o� -   5         o�Name$ 	Hoofdmenu��5
      $	��Top=�6#   .@�5      m� -   5        $��	Afsluiten��5      6*   m� 5      $��
Afbeelding��6   .@�5      m� -   5         m�Name$ MnuTonenVerbergen��5      $��Tonen of Verbergen��66   5      m� 5      -   5        $ MnuVastWisselend��5      $��Vast of Wisselend��65   5      5      5      � 5   
    � ColumnDefinitions 5      �� 5      $	��53* �6#   �� 5      $
��401* �6#   .+�5      �� $)��#Aantal vierkante meters nieuw glas:��6   $
��Left=�6B   $��	10,35,0,0q�6]   $	��Top=�6p   $��2��6�   �� 5      $��UG-Waarde van het glas:��6   $
��Left=�66   $��	10,82,0,0q�6Q   $	��Top=�6d   $��2��6|   �� 5      -   5         ��Name$  ChkVerhoogdeTegemoetkoming��5      $��Verhoogde tegemoetkoming?��6;   $
��Left=�6_   $��
10,136,0,0q�6z   $	��Top=�6�   $��2��6�   �� 5      $��
Provincie:��6   $
��Left=�6)   $��
10,184,0,0q�6D   $	��Top=�6X   �� 5      -   5         ��Name$ LsbProvincie��5      $
��Left=�6,   $��80��6G   $��
89,184,0,0q�6S   $	��Top=�6g   $	��205��6   $��2��6�   �� 5      -   5         ��Name$ 	ImgCanvas��5      $
��Left=�6'   $	��158��6B   $��
332,35,0,0q�6O   $	��Top=�6c   $	��355��6{   $��1��6�   �� 5      -   5         ��Name$ BtnBerekenen��5      $��Premie berekenen��6+   $
��Left=�6F   $��242,229,0,0q�6a   $	��Top=�6v   $	��135��6�   $��35��6�   $��1��6�   �� 5      -	   5        $ BtnNieuw��5      $��Nieuwe start��6'   $
��Left=�6>   $��411,229,0,0q�6Y   $	��Top=�6n   $	��135��6�   $��35��6�   $��1��6�   �� 5       -
   5         ��Name$ TxtResultaat��5       $
��Left=�6,   $	��188��6G   $��10,285,0,-8q�6T   	 �� TextWrapping$
	 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��642��6�   $��2��6�   �� 5!      -   5        $ TxtAantalVierkanteMeter��5!      $
��Left=�67   $��23��6R   $��
120,39,0,0q�6^   $
	 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5"      -   5        $ TxtUgWaarde��5"      $
��Left=�6+   $��23��6F   $��
120,86,0,0q�6R   $
	 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5#      -   5        
 ��Name$
 LblAfbeelding��5#      $�� ��6+   $
��Left=�66   $��584,345,0,0q�6Q   $	��Top=�6f   $	��148��6~   $��1��6�   5%      5&      5'      