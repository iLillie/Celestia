<template>
  <div>
    <a-button type="primary">
      {{message}}
    </a-button>
  </div>
</template>

<script lang="ts">
import Vue from 'vue'


export default Vue.extend({
  name: 'IndexPage',
  data: () => ({
    message: ""
  }),
  created() {
    this.$axios.get('http://localhost:5000/api/home')
      .then(({data}) => {
        this.message = data;
      })
  }
})
</script>
