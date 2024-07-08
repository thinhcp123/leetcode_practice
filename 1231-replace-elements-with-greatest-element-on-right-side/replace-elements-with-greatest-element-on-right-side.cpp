class Solution {
public:
    vector<int> replaceElements(vector<int>& arr) {
        vector<int> output = arr;
        int max_num = -1;
        for(int i = arr.size()-1; i >= 0; i--){
            output[i] = max_num;
            max_num = max(max_num,arr[i]);
        }
        return output;
    }
};