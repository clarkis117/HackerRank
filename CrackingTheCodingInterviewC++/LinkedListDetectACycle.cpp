/*
Detect a cycle in a linked list. Note that the head pointer may be 'NULL' if the list is empty.

A Node is defined as:
*/
struct Node {
int data;
struct Node* next;
};


bool has_cycle(Node* head) {
	// Complete this function
	// Do not write the main method
	if (head == nullptr)
		return false;

	Node *slowNode = head, *fastNode = head;

	do
	{
		fastNode = fastNode->next;

		if (fastNode == nullptr)
			return false;

		fastNode = fastNode->next;

		slowNode = slowNode->next;
			
	} while (slowNode && fastNode && slowNode != fastNode);

	if (slowNode && fastNode && slowNode == fastNode)
	{
		slowNode = head;

		while (slowNode != fastNode)
		{
			slowNode = slowNode->next;
			fastNode = fastNode->next;
		}

		return true;
	}

	return false;
}
