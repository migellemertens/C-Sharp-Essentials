   M S B A M L   `   `   `  ����S  OWpfPremieBerekeningRamen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WpfPremieBerekeningRamenWpfPremieBerekeningRamen  5   	   )    #WpfPremieBerekeningRamen.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:WpfPremieBerekeningRamen     5   	     � Title$  WpfPremieBerekeningRamen��5   	   $��881.815��6*   $��1361.829��6;   .��5	      ]� .+�5
   
   o� -   5         o�Name$ 	Hoofdmenu��5
      $	��Top=�6#   .@�5      m� -   5        $��	Afsluiten��5      6*   m� 5      $��
Afbeelding��6   .@�5      m� -   5         m�Name$ MnuTonenVerbergen��5      $��Tonen of Verbergen��66   5      m� 5      -   5        $ MnuVastWisselend��5      $��Vast of Wisselend��65   5      5      5      � 5   
   .+�5      �� -   5         ��Name$ 
btnBereken��5      $��Premie berekenen��6)   $
��Left=�6D   $��1108,21,0,0q�6_   $	��Top=�6t   $	��212��6�   $��60��6�   $��22(�6�   $��Arial)�6�   �� 5      -   5        $ btnNieuw��5      $��Nieuwe start��6'   $
��Left=�6>   $��1108,115,0,0q�6Y   $	��Top=�6o   $	��212��6�   $��60��6�   $��22(�6�   $��Arial)�6�   �� 5      -   5         ��Name$ txtResultaat��5      $
��Left=�6,   $	��318��6G   $��107,472,0,0q�6T    �� TextWrapping$
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $
��1005��6�   $��Courier New)�6�   $��20(�6�   " �� VerticalScrollBarVisibility$ Visible=�6�   �� 5      -   5         ��Name$ cboProvincie��5      $
��Left=�6-   $��370,315,0,0q�6H   $	��Top=�5      $	��527��6/   $��Arial)�6;   $��24(�6N   $��50��6\   �� 5      -	   5         ��Name$ lblProvincie��5      $
��Left=�6*   $��142,314,0,0q�6E   $	��Top=�5      $��	Provincie��5      	 J� RenderTransformOrigin$	 1.077,1.048&�6$   $��51��6H   $	��158��6T   $��24(�6`   $��Arial)�6o   �� 5      -
   5        
 ��Name$
 picBeeld��5      $
��Left=�6&   $	��253��6A   $��
676,23,0,0q�6N   $	��Top=�6b   $	��406��6z   �� 5      -   5         ��Name$  chkVerhoogdeTegemoetkoming��5      $��Verhoogde tegemoetkoming?��6;   $
��Left=�5      $��143,211,0,0q�62   $	��Top=�6G   $��36(�6_   $��54��6m   $	��510��6y   $��Arial)�6�   �� 5      -   5        $ lblVierkanteMeters��5      $
��Left=�60   $��
143,62,0,0q�6K   $	��Top=�6_   $��Aantal vierkante meters :��5       $	 1.077,1.048&�65   $��49��6Y   $	��318��6e   $��24(�6q   $��Arial)�5!      �� 5"      -   5        $ txtAantalVierkanteMeter��5"      $
��Left=�67   $��49��6R   $��
526,57,0,0q�6^   $
 Wrap=�5#      $	��Top=�6%   $��96��6=   $��24(�6H   $	 
0.38,1.901&�5$      $��Arial)�64   6G   �� 5%      -   5        $ lblUGWaarde��5%      $
��Left=�6)   $��143,131,0,0q�6D   $	��Top=�6Y   $��Ug-waarde van het glas :��5&      $	 1.077,1.048&�64   $��49��6X   $	��318��6d   $��24(�6p   $��Arial)�5'      �� 5(      -   5        $ txtUgWaarde��5(      $
��Left=�6+   $��49��6F   $��526,126,0,0q�6R   $
 Wrap=�5)      $	��Top=�6%   $��96��6=   $��24(�6H   $	 
0.38,1.901&�5*      $��Arial)�64   5+      5,      5-      