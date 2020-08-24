/* * * * * * * * * * * * * * *
*  Programmer : Sean Vaughan *
*      CIS 279 - Wagner      *
*        Assignment 8        *
* * * * * * * * * * * * * * **/


public class Driver {

    public static void main(String args[]){
        //Create generic stack
        GenericStack stack = new GenericStack(5);
        stack.push("Tim");
        stack.push("Joe");
        stack.push("Sean");
        stack.push("Michael");
        stack.push("Tommy");
        stack.push("Ashley");
        stack.push("Hayden");

        //Print out number of elements in stack after adding.
        System.out.println("Number of elements in stack: " + stack.getSize());

        //Display last element in array/top of stack.
        System.out.println("\nElement at the top of the stack: " + stack.peek());

        //Print all elements in stack. (Pulls one at a time and removes from stack)
        System.out.println("List of stack elements: \n");
        while(!stack.isEmpty()){
            System.out.println(stack.pop());
        }
    }
}
