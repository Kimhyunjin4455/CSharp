using System;


namespace Basic
{





	class StackNode
	{
		public char data;
		public StackNode link;
	}



	class LinkedStack
	{
		StackNode top;

		public bool isEmpty()
		{
			return (top == null);
		}

		public void push(char item)
		{
			StackNode newNode = new StackNode();
			newNode.data = item;
			newNode.link = top;
			top = newNode;
			// Console.WriteLine("Inserted Item : " + item);
		}

		public char pop()
		{
			if (isEmpty())
			{
				throw new Exception("Deleting fail! Linked Stack is empty!!");

			}
			else
			{
				char item = top.data;
				top = top.link;
				return item;
			}
		}

		public void delete()
		{
			if (isEmpty())
			{
				Console.WriteLine("Deleting fail! Linked Stack is empty!!");

			}
			else
			{
				top = top.link;
			}
		}

		public char peek()
		{
			if (isEmpty())
			{
				throw new Exception("Peeking fail! Linked Stack is empty!!");

			}
			else
				return top.data;
		}

		public void printStack()
		{
			if (isEmpty())
				Console.WriteLine("Linked Stack is empty!! %n %n");
			else
			{
				StackNode temp = top;
				Console.WriteLine("Linked Stack>> ");
				while (temp != null)
				{
					Console.WriteLine("\t %c \n", temp.data);
					temp = temp.link;
				}
				Console.WriteLine();
			}
		}
	}




	class OptExp
	{
		public String exp;
		public int expSize;
		public char testCh, openPair;

		public bool testPair(String exp)
		{
			this.exp = exp;
			LinkedStack S = new LinkedStack();
			expSize = this.exp.Length;
			for (int i = 0; i < expSize; i++)
			{
				testCh = this.exp[i];
				switch (testCh)
				{
					case '(':
					case '{':
					case '[':
						S.push(testCh);
						break;
					case ')':
					case '}':
					case ']':
						if (S.isEmpty())
							return false;
						else
						{
							openPair = S.pop();
							if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
									|| (openPair == '[' && testCh != ']'))
								return false;
							else
								break;
						}
				}
			}
			if (S.isEmpty())
				return true;
			else
				return false;
		}
	}



	public class BracketTest
	{

		static void Main(String[] args)
		{
			OptExp opt = new OptExp();
			String exp = "(3*5)-6/2)";

			Console.WriteLine(exp);

			if (opt.testPair(exp))
				Console.WriteLine("괄호 맞음!!");
			else
				Console.WriteLine("괄호 틀림!!");
		}
	}

}



