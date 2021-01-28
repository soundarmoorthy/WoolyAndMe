package com.company;

class Knight {
    public int Stamina = 100;
    public String Name;
    public Knight Next;

    public Knight(String name) {
        this.Name = name;
    }

    private boolean LastKnightStanding() {
        return this.Next == null || this.Next == this;
    }

    public boolean DoKick(int power) {
        if (LastNightStanding())
            return false;
        this.Next.Stamina -= power;
        System.out.println(
                String.format("%s hits %s by %s damage points", Name, Next.Name, power));

        if (Next.Died()) {
            System.out.println(String.format("%s dies", Next.Name));
            this.Next = Next.Next;
        }
        return true;
    }

    public boolean Died() {
        return this.Stamina < 1;
    }
}
