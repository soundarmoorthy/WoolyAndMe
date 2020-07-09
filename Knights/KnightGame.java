package com.company;

import java.lang.*;

public class KnightGame {
    private Knight start;
    private Knight knight;
    private boolean gameEnd = false;

    public KnightGame(Knight start) {
        this.start = start;
        this.knight = start;
    }

    public Knight Start() {
        return start;
    }

    public void Progress() {
        knight = knight.Next;
    }

    public void DoKick(int pow) {
        var kicked = knight.DoKick(pow);
        if (!kicked) {
            gameEnd = true;
        }
    }

    private void endGame() {
        System.out.println(String.format("%s wins", knight.Name));
    }

    public boolean End() {
        return gameEnd;
    }

}
