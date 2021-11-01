import java.util.*;
 
abstract class Node implements Comparable<Node> {
    public  int frequency; // the frequency of this tree
    public  char data;
    public  Node left, right; 
    public Node(int freq) { 
      frequency = freq; 
    }
 
    // compares on the frequency
    public int compareTo(Node tree) {
        return frequency - tree.frequency;
    }
}
 
class HuffmanLeaf extends Node {
    
 
    public HuffmanLeaf(int freq, char val) {
        super(freq);
        data = val;
    }
}
 
class HuffmanNode extends Node {
    
    public HuffmanNode(Node l, Node r) {
        super(l.frequency + r.frequency);
        left = l;
        right = r;
    }

}


class Decoding {

/*  
	class Node
		public  int frequency; // the frequency of this tree
    	public  char data;
    	public  Node left, right;
    
*/ 

	void decode(String s, Node root) {
        StringBuilder sb = new StringBuilder();
        Node tmp = root;
        for (int i = 0; i < s.length(); i++)
        {
            if (s.charAt(i) == '0')
                tmp = tmp.left;
            else
                tmp = tmp.right;
            if (tmp.right != null && tmp.left != null)
                continue;
            else
            {
                sb.append(tmp.data);
                tmp = root;
            }
        }
        System.out.println(sb.toString());
    }

