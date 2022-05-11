<template>
  <ol class="list-none p-0 flex gap-2">
    <li v-for="item in items">
      {{item}}
    </li>
  </ol>
</template>

<script>
export default {
  name: "Breadcrumbs",
  props: {
    items: Array
  }
}
</script>

<style scoped>

</style>
