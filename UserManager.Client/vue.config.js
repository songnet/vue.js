module.exports = {
  baseUrl: '/',
  productionSourceMap: false,
  devServer: {
    proxy: {
      '/': {
        target: 'http://localhost:9002',// 请换成你的地址
        changeOrigin: true,
        pathRewrite: {
          '^/': ''
        }
      }
    }
   }
}