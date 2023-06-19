const http = require('http')
const fs = require('fs')
const port = 5000
const server = http.createServer((req,res) =>{
    if (req.url === '/') {
        fs.readFile("index.html", (err,data) => {
            if(err){
                console.log(err)
            } else{
                res.write(data)
                res.end()
            }
        })
    } else if (req.url === '/hanoi') {
        fs.readFile("hanoi.html", (err,data) => {
            if(err){
                console.log(err)
            } else{
                res.write(data)
                res.end()
            }
        })
    } else if (req.url === '/danang', (err,data) => {
        if(err){
            console.log(err)
        } else{
            res.write(data)
            res.end()
        }
    }) {
        fs.readFile("danang.html")
    } else if (req.url === '/hcm', (err,data) => {
        if(err){
            console.log(err)
        } else{
            res.write(data)
            res.end()
        }
    }) {
        fs.readFile("hcm.html")
    } else if (req.url === '/cantho', (err,data) => {
        if(err){
            console.log(err)
        } else{
            res.write(data)
            res.end()
        }
    }) {
        fs.readFile("cantho.html")
    } else {
        fs.readFile("notfound.html")
    }
    
})
server.listen(port, () => {
    console.log("My website run successfully !")
    console.log("http://localhost:5000")
})
