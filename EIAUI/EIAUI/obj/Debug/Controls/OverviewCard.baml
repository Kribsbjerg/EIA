   M S B A M L   `   `   `  ����@  <EIAUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:EIAUIEIAUI  5          EIAUI.OverviewCard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      localclr-namespace:EIAUI  5      -   5          >�Name$  Overviewcard��5
      $��60��5	      $	��340��6    � 	Resources 5         ContentStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers �� Binding	 �� Value  PrimaryColorBrush
 �Name � RowDefinitions � ColumnDefinitions ��Name  	LatoBlack  DarkTextColorBrush  BorderLineColorBrush �� Triggers :� RoutedEvent  LightTextColor	 �� To g� Duration �� 
TargetName �� TargetProperty P� Property P� Value �� 
TargetName��%m  &	        7  7  7  7  7  �� 5   
   " ��6%   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 
background��6!   ��5      �� 5   "   " ��6(   .�5   &   ��  � ��
 �����6C    5   &   �� 5   *    66   �� *
IsSelected+	 True6U   .a�5   .   ��  � ��8   6K   5   +   5   #   ._�5      � $
 	container��6#   
������  5   "   �� 5   &   $
��Auto �64   �� 5    &    5"   "   �� 5#   &   $��2* �67   �� 5$   &   $	��18* �67   �� 5%   &   $��* �67   .+�5(   "   �� $��1��6-   $��1��6:   $��0 5 0 5q�6J   $��Center=�6[   .+�5)   &   �� $ text1��6E   $��13(�6T   8�� $��0 0 0 2q�6�   ��60   �� *Cpr+��5*   *   �� 5+   .   " ��64   .�5,   2   ��  � ��
 �   �6O    5-   2   �� 5.   6    6B   �� *
IsSelected+	 True6a   .a�5/   :   ��  � ��
 �����6W   50   7   52   /   54   '   �� 55   &   $ text2��6O   $��12(�6^   $��CharacterEllipsis=�6l   $��20��6�   ��60   �� *TreatmentType+��56   *   �� 57   .   " ��64   .�58   2   ��  � ��8  6O    59   2   �� 5:   6    6B   �� *
IsSelected+	 True6a   .a�5;   :   ��  � ��
 �����6W   5<   7   5>   /   5@   '   5A   #   �� 5C   "   $��0��6)   $��3��66   $��1��6J   8�� 6U   5E      5F       5H      :� 5J      $ 
MouseEnter��6+   .[�5K   "   �� .��5L   &   �� .��5M   *   �� 8  $ 0:0:0.1D�6^   $ 	container��6q   $ Background.Color�6�   5N   '   5O   #   5P      :� 5Q      $ 
MouseLeave��6+   .[�5R   "   �� .��5S   &   �� .��5T   *   �� $ TransparentX�69   $ 0:0:0.1D�6J   $ 	container��6]   $ Background.Color�6   5U   '   5V   #   5W      P� 5X       � {� .  . �5Y   "   �� $ 	container��6?    � ��
 �   �6V   5Z      5\      5^      5_      5`      .��5c      �� #��[  5d      5h      