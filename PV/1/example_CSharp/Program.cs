int sum(int x, int y) {
    return x + y;
}

void sum_ref(ref int result, int x, int y) {
    result = x + y;
}

int sum1 = sum(1, 1);

int sum2 = 0;
sum_ref(ref sum2, 1, 1);

Console.WriteLine($"sum1 = {sum1}, sum2 = {sum2}");
