class Solution{
	int height(Node* root) {
        if(root == null){
            return 0;
        }
        
        return (height(root->left) + height(root->right) + 1);
    }
}