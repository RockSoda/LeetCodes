/**
 * @param {Function} fn
 */
let memoize = (fn) => {
    let map = {}
    return (...args) => {
        let key = args
        if(key in map) return map[key]
        return map[key] = fn(...args)
    }
}


/** 
 * let callCount = 0;
 * const memoizedFn = memoize(function (a, b) {
 *	 callCount += 1;
 *   return a + b;
 * })
 * memoizedFn(2, 3) // 5
 * memoizedFn(2, 3) // 5
 * console.log(callCount) // 1 
 */