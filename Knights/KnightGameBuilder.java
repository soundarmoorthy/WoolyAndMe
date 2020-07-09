package com.company;

public class KnightGameBuilder {
    public static KnightGame Build(int countOfKnights) {
        if (countOfKnights < 2)
            throw new IllegalArgumentException
                    ("Cannot play game, need two knights atleast");

        Knight current = new Knight("K1");
        Knight first = current;
        for (int i = 2; i <= countOfKnights; i++) {
            var _new = new Knight(String.format("K%s", i));
            current.Next = _new;
            current = current.Next;
        }
        current.Next = first;
        return new KnightGame(first);
    }
}
