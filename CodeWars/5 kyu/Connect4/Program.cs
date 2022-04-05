

char[] row1 = {' ', ' ', ' ', ' ', ' ', ' ', ' '};
char[] row2 = {' ', ' ', ' ', ' ', ' ', ' ', ' '};
char[] row3 = {' ', ' ', ' ', ' ', ' ', ' ', ' '};
char[] row4 = {' ', ' ', ' ', ' ', ' ', ' ', ' '};
char[] row5 = {' ', ' ', ' ', ' ', ' ', ' ', ' '};
char[] row6 = {' ', ' ', ' ', ' ', ' ', ' ', ' '};

printBoard();

// string play(int col){
//     printBoard();
    
// }

void printBoard(){
    Console.WriteLine($"| {row1[0]} | {row1[1]} | {row1[2]} | {row1[3]} | {row1[4]} | {row1[5]} | {row1[6]} |");
    Console.WriteLine($"| {row2[0]} | {row2[1]} | {row2[2]} | {row2[3]} | {row2[4]} | {row2[5]} | {row2[6]} |");
    Console.WriteLine($"| {row3[0]} | {row3[1]} | {row3[2]} | {row3[3]} | {row3[4]} | {row3[5]} | {row3[6]} |");
    Console.WriteLine($"| {row4[0]} | {row4[1]} | {row4[2]} | {row4[3]} | {row4[4]} | {row4[5]} | {row4[6]} |");
    Console.WriteLine($"| {row5[0]} | {row5[1]} | {row5[2]} | {row5[3]} | {row5[4]} | {row5[5]} | {row5[6]} |");
    Console.WriteLine($"| {row6[0]} | {row6[1]} | {row6[2]} | {row6[3]} | {row6[4]} | {row6[5]} | {row6[6]} |");
}

static bool checkWin(){
    return true;
}