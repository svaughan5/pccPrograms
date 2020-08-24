
public class GenericStack<E> {

    //Declare fields (Stack size only used for default constructor)
    public final static int STACK_SIZE = 5;
    private E[] array;
    private int size;

    //Default constructor
    public GenericStack(){
        array = (E[]) new Object[STACK_SIZE];
        size = 0;
    }

    //Constructor with starting capacity.
    public GenericStack(int capacity){
        array = (E[]) new Object[capacity];
        size = 0;
    }

    //Get size method
    public int getSize(){
        return size;
    }

    //Method to see if array is empty or not.
    public E peek(){
        if(isEmpty()){
            return null;
        }
        return array[size - 1];
    }

    //Method to push an element to the array.
    public void push(E o){
        if(size == array.length){ //If size of stack = array length double.
            doubleArray(); //Method call to double array.
        }
        array[size] = o;
        size++;
    }

    //Deletes element off the end of the array.(top of the stack)
    public E pop(){
        if(isEmpty()){
            return null;
        }
        E o = array[size - 1];
        size--;
        return o;
    }

    //Checks if the array is empty.
    public boolean isEmpty(){
        return (size == 0);
    }

    //Method to double array.
    private void doubleArray(){
        E[] newArray = (E[]) new Object[array.length * 2];

        for(int i = 0; i < size; i++){ //Fills array with known values, leaving others blank.
            newArray[i] = array[i];
        }

        array = newArray;
    }

}