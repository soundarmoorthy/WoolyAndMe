#include<iostream>
class Test
{
	private:
	public :
		Test()
		{
			std::cout<<"Inside Test";
			foo();
			std::cout<<"Outside Test";
		}
		virtual void foo(){}
};

class Test1 : public Test
{
private:
	int a;
	public :
	Test1()
     {
	std::cout<<"Inside Test1";
     }
    void foo()
{
	a = 100;
	std::cout<<"a value is " <<a;
}
};

int main(int argc, char** argv)
{
    Test1* t = new Test1();
}

