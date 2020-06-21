function caesarCipher(s, k) {
        let res = '';

        s.split('').forEach(e => {
            let code = e.charCodeAt(0);

            if (e.match(/[A-Z]/)) {
                if ((code + k) > 90) {
                    let r = (code + k - 90) % 26;
                    r ? r = r : r = 26;
                    res += String.fromCharCode(64 + r);
                } else {
                    res += String.fromCharCode(code + k);
                }
            } else if (e.match(/[a-z]/)) {
                if ((code + k) > 122) {
                    let r = (code + k - 122) % 26;
                    r ? r = r : r = 26;
                    res += String.fromCharCode(96 + r);
                }
                else {
                    res += String.fromCharCode(code + k);
                }
            } else {
                res += e;
            }
        });

        return res;
}
