#include <climits> 

/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

The Node struct is defined as follows:
	struct Node {
		int data;
		Node* left;
		Node* right;
	}
*/
	bool checkBST(Node* root) {
        if (root->left->data < root->data && root->right->data > root->data)
		  return check(root, INT_MIN, INT_MAX);
        return false;
	}

    bool check(Node* root, int left, int right)
    {
        if (root ==  nullptr)
            return true;
        return (left < root->data && root->data < right
               && check(root->left, left, root->data)
               && check(root->right, root->data, right));
    }
