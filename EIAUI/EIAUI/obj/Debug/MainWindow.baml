   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   @ <EIAUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EIAUIEIAUI 5   	      EIAUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   %localclr-namespace:EIAUI     5   	   -   5          �Name$  	AppWindow��5   	    � WindowStyle$
 None=�5	   	    � AllowsTransparency .  � Title$ 
MainWindow��5   	   $	��400��5   	   $
��1050��5   	   $	��400��5   	   $
��1080��5   	    � Left$
 1920��5   	    � WindowStartupLocation$ Manual=�5   	   
 � Top$ 0��5   	    � 	Resources 5        EIAUI.MainWindow �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� Padding J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Opacity   
BlurRadius ��Name   BackgroundColorBrush J� OpacityMask !� Visual �� ElementName � RowDefinitions K� ZIndex � ColumnDefinitions  WindowControlButton.   (System.Windows.Interactivity.Interaction   Triggers/   )System.Windows.Interactivity.EventTrigger   	EventName.   (System.Windows.Interactivity.TriggerBase   Actions6   0System.Windows.Interactivity.InvokeCommandAction   Command �Name)  #EIAUI.VisitationCardListDesignModel   Instance � DataContext  EIAUI.VisitationTab �� Triggers �� Binding  �� RelativeSource! �� AncestorType" �� Path# �� Value$   ShadowDepth  PrimaryColorBrush% �� TextAlignment  MaterialIcon& ��Name  LatoRegular' �� Mode( �� UpdateSourceTrigger  CloseSearch  ActiveTabColorBrush) �� SelectedItem	  EIAUI.OverviewCard* � HorizontalOffset+ � VerticalOffset, � AllowsTransparency
  EIAUI.MorningMessage��%�  '        7   7  7  7  7  7  7  7  7  �� 5   
   "  6   .�5      �� 	 � ��
 5      �� 5      " �6&   .R�5      ��  6!   �� *OuterMarginSizeThickness+ 5        5   "   $	 0.7Q�63   $ 20Q�6A   ._�5#      � .+�5&   "   �� $ 	Container��6)   8��  5'   )   �� 5*   "   
�������5-   #   � 50   "    51   &   !� 52   *    66   �� $ 	Container�� 55   &   �� 58   *   $	��120 �68   �� 5;   *   $
��auto �68   .+�5@   &   � $��0��6+   $ 1��6;    5B   *   �� 5D   .   $��* �6?   �� 5F   .   $��7* �6?   �� 5H   .   $��* �6?   .+�5L   *   �� $��0��61   $��>��6e   8�� ��6A   �� *MinimizeCommand+6q   �� 5O   *   $��1��60   $$��Images/Logo/enversion-logo.png��6@   $��	0 15 0 15q�6h   �� 5R   *   $��2��61   |�.  $��50��6S   $	����6_   8��  5S   .     5T   2   $ PreviewMouseUp��6A   . 5U   6      6L   �� *SearchCommand+5V   3   5X   +   5Y   '   � 5[   &   $ 
TabContent��6+   $��1��6?   # Z 6L   .+�5a   *     >� 5e   *   $��1��66   $��Center=�6C   $��Center=�6`   ��5g   .   �� 5h   2   " >�68    5i   6   �� 5j   :    6F   ��   �� *FindAncestor+"! �$!" DataContext.SearchActivated�# True5k   �   .a�5l   >   �� 	 � y�$
 Visible=�6[   5m   ;   �� 5n   :    6F   ��   �� *FindAncestor+"! �$!" DataContext.SearchActivated�	# False5o   �   .a�5p   >   �� 	 � y�$
 	Collapsed=�6[   5q   ;   5s   3   .��5v   .   � 
������� 5w   2   �� 5x   6   $��* �6D   �� 5y   6   $	��10* �6D   .+�5|   2   � $��0��67   $��80��6D   $	��400��6P   .+�5~   6   �� $ 0 10 0 0q�6=    5�   :     5�   >   $$ 0Q�6O   $	 0.6Q�6_   $ 10Q�6m   ._�5�   :   � 
�������$	��330��6R   $��10q�6^    5�   >   �� 5�   B   $��2* �6S   �� 5�   B   $	��10* �6S   �� 5�   B   $��* �6S   .+�5�   >   �� $��0��6H   8�� $��50��6�   $	����6�   $% Center=�6�   $��26(�6�   8�� $��Center=�6�   $��Center=�6  �� 5�   >   $& SearchField��6V   $��1��6F   $��1 5 5 0q�5�   B   $��Center=�5�   B   8�� $��14(�5�   B   $	��290��5�   B   $��50��5�   B   $��Center=�5�   B   ��5�   k   �� *
SearchWord+$' TwoWay=�$( PropertyChanged=�.��5�   e   ��5�   B   �� 5�   F   " ��6L   .�5�   J   �� 	 � ��$
 0q�6l   6y    5�   J   �� 5�   N    6Z   ��   �� *FindAncestor+"! �$!" DataContext.SearchActivated�# True5�   �   .a�5�   R   �� 	 �@+�FocusedElement
 6�   �� $ SearchField��5�   O   5�   G   .��5�   Q   5�   ?   5�   ;   5�   7   �� 5�   6   8�� $��330 -40 0 0q�6b   $ 0��6w   ��6�   ��   �� *FindAncestor+"! �$" DataContext.SearchCommand�5�   3   � 5�   2   $��1��67   $	��900��6D   .+�5�   5   �� $
��Auto=�6B   $��0, 10, 0, 0q�6e   $��2��6z   
������ $��1q�6�   8�� $	��380��6�   .��5�   6   �� $��5q�6�   $��Center=�6�   $��0q�6�   8�� ��6>   �� *SearchResult+) 6c   �� *SelectedCard+��5�   :   �� 5�   >   " ��6D   .�5�   B   �� 	 �@��
IsSelected
 6_   �� *Content.IsSelected+$' TwoWay=�  �� *Self+�� 5�   B   	 � ��

 �  ��6_   �� 5�   B   	 � ��
 5�   F   �� 5�   J   " ��6Z   .R�5�   N   �� 5�   K   5�   C   5�   ?    5�   >     5�   B   $$ 0Q�6S   $	 0.6Q�6c   $ 10Q�6q   ��5�   :   �� 5�   >   .R�5�   F   � .+�5�   J   	  5�   C   5�   ?   5�   7   5�   7   5�   3   5�   /   5�   +   5�   '   5�   #   � 5�   "   $
* -350��5�   (   $
+ -250��5�   (   , . ��5�   (   �� *IsMorningNotificationOpen+.��5�   &   
  5�   #   5�      5�      5�      5�      5�      5�      - J� InputBindings- 5�      �� 5�   
   
. �� Key$. F��6   / �� 	Modifiers$
/ Ctrlf�6   0 �� Command0 6/   �� *SearchCommand+'  !System.Windows.Shell.WindowChrome1   WindowChrome1 5�        5�   
   2   GlassFrameThickness$2 0q�5�      3   ResizeBorderThickness3 5�      �� *ResizeBorderThickness+4   CornerRadius4 5�      �� 5�      