//1. Khai báo module 'http' để chạy web
const http = require('http')
//2. Khai báo web server/hosting (optional)
const host = 'localhost'
//3. Khai báo server port
const port = 3000
//4. Khởi tạo server
const server = http.createServer((request, response) =>{
    response.write("<h1 style='color: red; font-style: italic; text-decoration: underline'>Cloud Computing - GCH1101</h1>")
    response.write("<h2 style='text-align: center'>PRACTICE MAKES PERFECT</h2>")
    response.end()
})
//5. Chạy server bằng cách listen port
server.listen(port, () =>{
    console.log("Web server is running at http://" + host + ':' + port)
    //console.log("Web server is running at http://localhost:3000")
})