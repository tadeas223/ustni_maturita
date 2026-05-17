import unittest

class TestMath(unittest.TestCase):
    def test_sum(self):
        self.assertEqual(sum(1, 2), 3)
        self.assertEqual(sum(1, 3), 4)
        self.assertEqual(sum(1, 4), 5)

def sum(x, y):
    """
        Sums two numbers.
        returns x + y.
    """
    return x + y

if __name__ == "__main__":
    help(sum)
    unittest.main()
