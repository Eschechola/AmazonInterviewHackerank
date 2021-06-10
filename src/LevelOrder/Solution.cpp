class Solution{
	void levelOrder(Node * root) {
        queue<Node *> elementq;
        
        elementq.push(root);
        
        Node *temp = NULL;
        while(!elementq.empty())
        {   
            temp = elementq.front();
            elementq.pop();
            cout << temp->data << " ";
            
            if(temp->left)
            {
                elementq.push(temp->left);
            }
            
            if(temp->right)
            {
                elementq.push(temp->right);
            }
        }
    }
}