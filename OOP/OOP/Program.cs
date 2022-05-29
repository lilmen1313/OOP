int x1 = 1;
int y1 = 3;
char sym = '*';
Draw(x1, y1, sym);

void Draw (int x, int y, char sym)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(sym);
}