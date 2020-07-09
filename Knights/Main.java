package com.company;


import java.util.Random;

public class Main
{
    static final int knights = 6;
    public static void main(String[] args)
    {
        KnightGame game = KnightGameBuilder.Build(knights);

        game.Start();
        while(!game.End())
        {
            game.DoKick(pow());
            game.Progress();
        }
    }

    private static Random r = new Random(1);
    private static int pow()
    {
        int rand = r.nextInt(knights) +1;
        return rand;
    }
}
