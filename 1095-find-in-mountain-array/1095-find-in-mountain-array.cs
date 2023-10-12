/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution 
{
    private int GetPeakIdx(MountainArray mountainArr, int size)
    {
        int left = 0;
        int right = size - 1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            int prev = mid-1 < 0 ? -1 : mountainArr.Get(mid-1);
            int curr = mountainArr.Get(mid);
            int next = mid+1 >= size ? (int)Math.Pow(10,9)+1 : mountainArr.Get(mid+1);
            
            if (prev < curr && curr < next) left = mid + 1;
            else if (prev > curr && curr > next) right = mid - 1;
            else return mid;
        }
        
        return -1;
    }
    
    private int GetTargetIdxFromLeft(int target, MountainArray mountainArr, int peakIdx)
    {
        int left = 0;
        int right = peakIdx;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int curr = mountainArr.Get(mid);
            
            if (curr < target) left = mid + 1;
            else if (curr > target) right = mid - 1;
            else return mid;
        }
        
        return -1;
    }
    
    private int GetTargetIdxFromRight(int target, MountainArray mountainArr, int peakIdx, int size)
    {
        int left = peakIdx;
        int right = size - 1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int curr = mountainArr.Get(mid);
            
            if (curr > target) left = mid + 1;
            else if (curr < target) right = mid - 1;
            else return mid;
        }
        
        return -1;
    }
    
    public int FindInMountainArray(int target, MountainArray mountainArr) 
    {
        int size = mountainArr.Length();
        
        int peakIdx = GetPeakIdx(mountainArr, size);
        
        int leftSearchIdx = GetTargetIdxFromLeft(target, mountainArr, peakIdx);
        
        if (leftSearchIdx != -1) return leftSearchIdx;
        
        return GetTargetIdxFromRight(target, mountainArr, peakIdx, size);
        
    }
}